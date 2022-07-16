using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demographic
{
    public struct PopulationInfo
    {
        public int Year;
        public int Population;
    }

    public struct AgeStructure
    {
        public AgeRange Range;
        public int Count;
    }

    public class AgeRange
    {
        public int Min { get; }
        public int Max { get; }

        public AgeRange(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }

    public class SimulationResult
    {
        public static AgeRange[] AgeRanges { get; } =
        {
            new AgeRange(0, 18),
            new AgeRange(19, 45),
            new AgeRange(45, 65),
            new AgeRange(66, 100)
        };

        public List<PopulationInfo> PopulationDynamics { get; set; }
        public List<PopulationInfo> MalePopulationDynamics { get; set; }
        public List<PopulationInfo> FemalePopulationDynamics { get; set; }
        public List<AgeStructure> MaleAgeStructure { get; set; }
        public List<AgeStructure> FemaleAgeStructure { get; set; }

        public SimulationResult()
        {
            PopulationDynamics = new List<PopulationInfo>();
            MalePopulationDynamics = new List<PopulationInfo>();
            FemalePopulationDynamics = new List<PopulationInfo>();
            MaleAgeStructure = new List<AgeStructure>();
            FemaleAgeStructure = new List<AgeStructure>();
        }
    }
}
