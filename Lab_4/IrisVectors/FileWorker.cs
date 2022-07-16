using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LinearAlgebra;

namespace ChartsVisualisation
{
    class FileWorker 
    {
        
        private const double value = 10000;

        public string[] ReadFile(string fileName)
        {
            long length = new System.IO.FileInfo(fileName).Length;
            if (length > value)
            {
                throw new FileLoadException("Слишком большой файл");
            }

            if (!File.Exists(fileName))
                throw new FileNotFoundException();

            
            string[] arrayStrings = File.ReadAllLines(fileName);
            return arrayStrings;
        }
    }
}
