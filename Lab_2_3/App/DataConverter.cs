using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2lab;

namespace App
{
    class DataConverter
    {
        private List<List<double>> _averagedVectors = new List<List<double>>();

        public DataConverter() {}

        /// <summary>Конструктор копирования.</summary>
        public DataConverter (DataConverter converter)
        {
            _averagedVectors = converter._averagedVectors;
        }

        /// <summary>Получить список усреднённых векторов.</summary>
        public void GetAveragedVectors(List<List<double>> vectorsSetosa, List<List<double>> vectorsVersicolor, List<List<double>> vectorsVirginica)
        {
            List<MathVector> setosa = new List<MathVector>();
            List<MathVector> versicolor = new List<MathVector>();
            List<MathVector> virginica = new List<MathVector>();
            for (int i = 0; i < vectorsSetosa.Count; i++)
            {
                setosa.Add(new MathVector(vectorsSetosa[i]));
                versicolor.Add(new MathVector(vectorsVersicolor[i]));
                virginica.Add(new MathVector(vectorsVirginica[i]));
            }
            double a = setosa[0][0];
            List<List<MathVector>> vectors = new List<List<MathVector>>() { setosa, versicolor, virginica };
            int coordinates = 4;
            for (int z = 0; z < vectors.Count; z++) // Идём по самим векторам
            {
                MathVector tempList = new MathVector(4);
                for (int i = 0; i < coordinates; i++)
                {
                    double tempSum = 0;
                    for (int j = 0; j < vectors[z].Count; j++) // Идём по строкам каждого из векторов
                    {
                        tempSum += vectors[z][j][i];
                    }
                    tempList[i] += tempSum / 50;
                }
                _averagedVectors.Add(tempList.GetCoordinates());
            }
        }

        /// <summary>Получить список усреднённых координат вектора по его индексу.</summary>
        /// <param name="index">Индекс вектора.</param>
        /// <returns>Список усреднённых координат вектора по его индексу</returns>
        public List<double> GetAveragedVector(int index)
        {
            return new List<double>(_averagedVectors[index]);
        }

        /// <summary>Получить координату усреднённого вектора по индексам.</summary>
        /// <param name="index1">Индекс вектора.</param>
        /// <param name="index2">Индекс координаты вектора</param>
        /// <returns>Координата усреднённого вектора по индексам.</returns>
        public double GetValueOfAveragedVector(int index1, int index2)
        {
            return _averagedVectors[index1][index2];
        }
    }
}
