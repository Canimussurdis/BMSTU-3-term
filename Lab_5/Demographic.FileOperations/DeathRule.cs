using System;

namespace Demographic.FileOperations
{
    public class DeathRule
    {
        public int MinAge { get; private set; }
        public int MaxAge { get; private set; }
        public float MaleDeathProbability { get; private set; }
        public float FemaleDeathProbability { get; private set; }

        public DeathRule(int minAge, int maxAge, float maleProbability, float femaleProbability)
        {
            MinAge = minAge;
            MaxAge = maxAge;
            MaleDeathProbability = maleProbability;
            FemaleDeathProbability = femaleProbability;
        }
    }
}
