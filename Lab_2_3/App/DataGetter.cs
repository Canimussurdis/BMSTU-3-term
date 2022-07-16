using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App
{
    class DataGetter
    {
        private List<List<double>> _vectorsSetosa = new List<List<double>>();
        private List<List<double>> _vectorsVersicolor = new List<List<double>>();
        private List<List<double>> _vectorsVirginica = new List<List<double>>();
        private DataConverter _converter = new DataConverter();


        /// <summary>Получить 3 списка векторов из файла и список усреднённых векторов по этим 3м векторам.</summary>
        /// <param name="filename">Путь файла.</param>
        public void GetVectors(string filename)
        {
            List<string> text = new List<string>();
            text.AddRange(File.ReadAllLines(filename));
            text.RemoveAt(0);
            MakeVectorsFromString(text);
            _converter.GetAveragedVectors(_vectorsSetosa, _vectorsVersicolor, _vectorsVirginica);
        }

        /// <summary>Получить 3 списка векторов по их названиям.</summary>
        /// <param name="text">Список, содержащий все строки с координатами из файла.</param>
        private void MakeVectorsFromString(List<string> text)
        {
            string temp = "";
            for (int i = 0; i < text.Count; i++)
            {
                List<double> tempList = new List<double>();
                int countCommas = 0;
                for (int j = 0; j < text[i].Length; j++)
                {
                    if (countCommas < 4)
                    {
                        if (text[i][j] != ',')
                        {
                            if (text[i][j] == '.')
                                temp += ',';
                            else
                                temp += text[i][j];
                        }
                        else
                        {
                            tempList.Add(double.Parse(temp));
                            temp = "";
                            countCommas++;
                        }
                    }
                }
                if (text[i].Substring(text[i].Length - 6) == "setosa")
                    _vectorsSetosa.Add(tempList);
                else if (text[i].Substring(text[i].Length - 10) == "versicolor")
                    _vectorsVersicolor.Add(tempList);
                else if (text[i].Substring(text[i].Length - 9) == "virginica")
                    _vectorsVirginica.Add(tempList);
            }
        }

        /// <summary>Получить новый объект класса DataConverter с данными по считанному файлу.</summary>
        /// <returns>новый объект класса DataConverter с данными по считанному файлу.</returns>
        public DataConverter GetConverter()
        {
            return new DataConverter(_converter);
        }
    }
}
