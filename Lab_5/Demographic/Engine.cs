using Demographic.Exceptions;
using Demographic.FileOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    // делегат - указатель на метод
    public delegate void YearTickHandler(int currentYear);

    public class Engine : IEngine
    {
        public int StartingYear { get; set; } = 1970;
        public int EndingYear { get; set; } = 2021;
        public uint NumberOfPeople { get; set; } = 130_000_000u;

        //событие, которое представляет делегат YearTickHandler
        // событие можем вызывать как метод
        private event YearTickHandler YearTick; 
        

        private List<Person> _people;
        private DemographicDataProvider _dataProvider;
        private AgeStatistics[] _ageStatistics;
        private DeathRule[] _deathRules;
        private List<Child> _children;

        public Engine()
        {
            _dataProvider = new DemographicDataProvider();
        }

        public void LoadInitialAges(string filePath)
        {
            _ageStatistics = _dataProvider.ReadAgeStatistics(filePath);
        }

        public void LoadDeathRules(string filePath)
        {
            _deathRules = _dataProvider.ReadDeathRules(filePath);
        }

        public SimulationResult RunSimulation(Action<SimulationResult> callback)
        {
            AssertDataIsCorrect();
            // контрольное значение для делегата - анонимный метод, который устраняет 
            // необходимость проверки на null.
            // Можно было так: YearTick?.Invoke(что-то там);
            YearTick = delegate { };
            InitializePeople();
            _children = new List<Child>();
            SimulationResult result = new SimulationResult();

            for (int i = StartingYear; i <= EndingYear; i++)
            {
                YearTick(i);
                RemoveDead(); 
                AddChildren();
                ProcessAnnualStatistics(i, ref result);
                callback(result);
            }

            ProcessFinalStatistics(ref result);
            return result;
        }

        public void AssertDataIsCorrect()
        {
            if (EndingYear <= StartingYear)
                throw new EngineException("The last year of the simulation must be greater than the first year");

            if (NumberOfPeople == 0)
                throw new EngineException("Incorrect population");

            if (NumberOfPeople % Person.RepresentedAmount != 0)
                throw new EngineException($"The initial population must be divisible by {Person.RepresentedAmount}");

            if (_ageStatistics == null || _ageStatistics.Length == 0)
                throw new EngineException("The age statistics have not been loaded");

            if (_deathRules == null || _deathRules.Length == 0)
                throw new EngineException("The death rules have not been loaded");
        }

        private void RemoveDead() 
        {
            for (int i = 0; i < _people.Count; i++)
            {
                if (!_people[i].IsAlive)
                {
                    RemoveHandlers(_people[i]);
                    _people.Remove(_people[i]);
                    _people.RemoveAt(i);
                }

            }
        }

        private void RemoveHandlers(Person p)
        {
            YearTick -= p.OnYearPassed; // удаление обработчика события
            if (p.Gender == Gender.Female)
                (p as Female).ChildBirth -= OnChildBirth; // удаление обработчика события
        }

        private void AddChildren()
        {
            foreach (var child in _children)
                AddNewPerson(child.Gender, child.BirthYear, 0);
            _children.Clear();
        }

        private void ProcessFinalStatistics(ref SimulationResult result)
        {
            foreach (var range in SimulationResult.AgeRanges)
            {
                var maleCount = _people.Count(p => IsInAgeRange(p, range) && p.Gender == Gender.Male);
                var femaleCount = _people.Count(p => IsInAgeRange(p, range) && p.Gender == Gender.Female);
                result.MaleAgeStructure.Add(new AgeStructure { Range = range, Count = maleCount });
                result.FemaleAgeStructure.Add(new AgeStructure { Range = range, Count = femaleCount });
            }
        }

        private bool IsInAgeRange(Person person, AgeRange range)
        {
            var age = EndingYear - person.BirthYear;
            return age >= range.Min && age <= range.Max;
        }

        private void ProcessAnnualStatistics(int year, ref SimulationResult result)
        {
            int malePopulation = _people.Count(p => p.Gender == Gender.Male);
            int femalePopulation = _people.Count(p => p.Gender == Gender.Female);

            var generalStatistics = new PopulationInfo { Year = year, Population = _people.Count };
            var maleStatistics = new PopulationInfo { Year = year, Population = malePopulation };
            var femaleStatistics = new PopulationInfo { Year = year, Population = femalePopulation };

            result.PopulationDynamics.Add(generalStatistics);
            result.MalePopulationDynamics.Add(maleStatistics);
            result.FemalePopulationDynamics.Add(femaleStatistics);
        }

        private void OnChildBirth(Child child)
        {
            _children.Add(child);
        }

        private void InitializePeople()
        {
            uint totalCount = NumberOfPeople / (uint)Person.RepresentedAmount;
            _people = new List<Person>();

            foreach (AgeStatistics record in _ageStatistics)
            {
                int numberOfIterations = 
                    (int)Math.Ceiling(record.RelativeAmount * totalCount / Person.RepresentedAmount / 2);

                for (int j = 0; j < numberOfIterations && _people.Count < totalCount; j++)
                {
                    int birthYear = StartingYear - record.Age;

                    AddNewPerson(Gender.Male, birthYear, record.Age);
                    AddNewPerson(Gender.Female, birthYear, record.Age);
                }
            }
        }

        private void AddNewPerson(Gender gender, int birthYear, int age)
        {
            if (gender == Gender.Male)
            {
                var male = new Male(birthYear, GetProbability(Gender.Male, age));
                _people.Add(male);
                YearTick += male.OnYearPassed; //добавление обработчика - то, что выполняется при вызове обработчика
            }
            else
            {
                var female = new Female(birthYear, GetProbability(Gender.Male, age));
                _people.Add(female);
                YearTick += female.OnYearPassed; // добавление обработчика
                female.ChildBirth += OnChildBirth;
            }
        }

        private float GetProbability(Gender gender, int age)
        {
            var ruleForAge = _deathRules.FirstOrDefault(rule => age >= rule.MinAge && age <= rule.MaxAge);

            if (ruleForAge == default(DeathRule))
                return 0f;

            if (gender == Gender.Male)
                return ruleForAge.MaleDeathProbability;

            return ruleForAge.FemaleDeathProbability;
        }
    }
}
