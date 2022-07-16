using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public class Child
    {
        public Gender Gender { get; private set; }
        public int BirthYear { get; private set; }

        public Child(Gender gender, int birthYear)
        {
            Gender = gender;
            BirthYear = birthYear;
        }
    }
}
