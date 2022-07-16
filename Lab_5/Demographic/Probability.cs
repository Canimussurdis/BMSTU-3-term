using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public static class Probability
    {
        private static readonly Random _random = new Random();

        public static bool EventHappened(float probability)
        {
            return _random.NextDouble() <= probability; 
        }
    }
}
