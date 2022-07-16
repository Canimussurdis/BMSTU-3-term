using Demographic.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Demographic.FileOperations
{
    /// <summary>
    /// A class that parses csv files into string matrices
    /// </summary>
    class CSVParser
    {
        private string[] _lines;
        private char _delimiter;
        private const int MaxSizeInBytes = 100 * 100 * 100;

        /// <summary>
        /// A constructor that reads a specific file
        /// </summary>
        /// <param name="path">A path to the target file</param>
        /// <param name="delimiter">A column separator in the file</param>
        public CSVParser(string path, char delimiter = ',')
        {
            try
            {
                if (new FileInfo(path).Length > MaxSizeInBytes) 
                    throw new OpenFileException();
                _lines = File.ReadAllLines(path);
            }
            catch (Exception)
            {
                throw new OpenFileException();
            }

            _delimiter = delimiter;
        }

        /// <summary>
        /// Converts already read file to a string matrix
        /// </summary>
        /// <returns>A string matrix that represents the table</returns>
        /// <exception cref="CSVParseException"/>
        public string[][] Parse()
        {
            if (_lines.Length == 0)
                throw new CSVParseException();

            string[] headers = _lines[0].Split(_delimiter);

            if (headers.Length == 0)
                throw new CSVParseException();

            string[][] data = new string[_lines.Length][];

            data[0] = headers;
            for (int i = 1; i < _lines.Length; i++)
                data[i] = _lines[i].Split(_delimiter);

            return data;
        }
    }
}
