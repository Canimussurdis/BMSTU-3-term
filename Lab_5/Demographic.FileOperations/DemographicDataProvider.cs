using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Demographic.Exceptions;

namespace Demographic.FileOperations
{
    public class DemographicDataProvider
    {
        /// <exception cref="CSVParseException"></exception>
        /// <exception cref="OpenFileException"></exception>
        public AgeStatistics[] ReadAgeStatistics(string path)
        {
            return LoadData(path).Select(row => ParseAgeStatstics(row)).ToArray();
        }

        /// <exception cref="CSVParseException"></exception>
        /// <exception cref="OpenFileException"></exception>
        public DeathRule[] ReadDeathRules(string path)
        {
            return LoadData(path).Select(row => ParseDeathRule(row)).ToArray();
        }

        private IEnumerable<string[]> LoadData(string path)
        {
            var data = new CSVParser(path).Parse().Skip(1);
            if (data.Count() == 0)
                throw new CSVParseException();
            return data;
        }

        private AgeStatistics ParseAgeStatstics(string[] row)
        {
            if (row.Length != 2)
                throw new CSVParseException();

            int age = int.Parse(row[0], CultureInfo.InvariantCulture);
            float amount = float.Parse(row[1], CultureInfo.InvariantCulture);
            return new AgeStatistics(age, amount);
        }

        private DeathRule ParseDeathRule(string[] row)
        {
            if (row.Length != 4)
                throw new CSVParseException();

            int min = int.Parse(row[0], CultureInfo.InvariantCulture);
            int max = int.Parse(row[1], CultureInfo.InvariantCulture);
            float male = float.Parse(row[2], CultureInfo.InvariantCulture);
            float female = float.Parse(row[3], CultureInfo.InvariantCulture);
            return new DeathRule(min, max, male, female);
        }
    }
}
