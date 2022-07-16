using System;
using Demographic.Exceptions;

namespace Demographic
{
    public interface IEngine
    {
        /// <summary>
        /// <para>Reads CSV file with initial ages and their relative amounts</para>
        /// <code>age, amount_per_N</code>
        /// </summary>
        /// <exception cref="CSVParseException"/>
        /// <exception cref="OpenFileException"/>
        void LoadInitialAges(string filePath);

        /// <summary>
        /// <para>Reads CSV file with death rules</para>
        /// <code>min_age, max_age, probability_for_males, probability_for_females</code>
        /// </summary>
        /// <exception cref="CSVParseException"/>
        /// <exception cref="OpenFileException"/>
        void LoadDeathRules(string filePath);

        /// <summary>
        /// Makes sure that the loaded data is correct before running the simulation.
        /// Throws an exception if it's not
        /// </summary>
        /// <exception cref="EngineException"/>
        void AssertDataIsCorrect();

        /// <summary>
        /// Runs the simulation
        /// </summary>
        /// <returns><see cref="SimulationResult"/></returns>
        /// <exception cref="EngineException"/>
        SimulationResult RunSimulation(Action<SimulationResult> callback);
    }
}
