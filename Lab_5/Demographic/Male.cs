using System;

namespace Demographic
{
    class Male : Person
    {
        public Male(int birthYear, float deathProbability)
            : base(Gender.Male, birthYear, deathProbability) { }
    }
}
