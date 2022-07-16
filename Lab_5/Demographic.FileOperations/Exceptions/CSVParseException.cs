using System;

namespace Demographic.Exceptions
{
    class CSVParseException : Exception
    {
        public CSVParseException()
            : base("Error parsing the file") { }
    }
}
