using System;

namespace Demographic
{
    public abstract class Person
    {
        public static readonly int RepresentedAmount = 1000;

        public Gender Gender { get; private set; }
        public int BirthYear { get; private set; }
        public bool IsAlive { get; private set; }
        public float DeathProbability { get; private set; }

        private int _deathYear;

        public Person(Gender gender, int birthYear, float deathProbability)
        {
            Gender = gender;
            BirthYear = birthYear;
            IsAlive = true;
            DeathProbability = deathProbability;
        }

        public virtual void OnYearPassed(int currentYear)
        {
            if (!IsAlive)
                return;

            bool hasDied = Probability.EventHappened(DeathProbability);

            if (hasDied)
            {
                IsAlive = false;
                _deathYear = currentYear;
            }
        }

        public int GetAge(int currentYear)
        {
            return currentYear - BirthYear;
        }

        public int GetDeathYear()
        {
            if (!IsAlive) 
                return _deathYear; 
            else 
                throw new Exception("Not dead");
        }
    }
}
