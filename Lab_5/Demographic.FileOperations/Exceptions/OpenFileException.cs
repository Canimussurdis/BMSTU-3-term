using System;

namespace Demographic.Exceptions
{
    class OpenFileException : Exception
    {
        public OpenFileException()
            : base ("Error opening the file") { }
    }
}
