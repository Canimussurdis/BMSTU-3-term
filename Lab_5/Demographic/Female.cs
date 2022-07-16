using System;

namespace Demographic
{
    public delegate void BirthHandler(Child child);

    class Female : Person
    {
        public static readonly int ChildBirthMinAge = 18;
        public static readonly int ChildBirthMaxAge = 45;
        public static readonly float BirthProbability = 0.151f;
        public static readonly float MaleBirthProbability = 0.45f;

        public event BirthHandler ChildBirth;

        public Female(int birthYear, float deathProbability)
            : base(Gender.Female, birthYear, deathProbability) { }

        public override void OnYearPassed(int currentYear)
        {
            base.OnYearPassed(currentYear);

            if (!IsAlive)
                return;

            if (CanHaveBaby(currentYear))
            {
                bool gaveBirth = Probability.EventHappened(BirthProbability);

                if (gaveBirth)
                {
                    bool isMale = Probability.EventHappened(MaleBirthProbability);
                    var gender = isMale ? Gender.Male : Gender.Female;
                    ChildBirth(new Child(gender, currentYear));
                }
            }
        }

        private bool CanHaveBaby(int currentYear)
        {
            int age = currentYear - BirthYear;
            return age >= ChildBirthMinAge && age <= ChildBirthMaxAge;
        }
    }
}
