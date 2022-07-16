using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LinearAlgebra;

namespace Clustering
{
    public class KmeansClusterer : IClusterer
    {
        private MathVector[] _points;
        private MathVector[] _centroids;
        private Random _random = new Random();

        public MathVector[] Points { get { return _points; } }
        public MathVector TopRightBound { get; private set; }
        public MathVector BottomLeftBound { get; private set; }

        public void LoadPointsFromFile(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);
            _points = new MathVector[lines.Length];
            TopRightBound = new MathVector(double.NegativeInfinity, double.NegativeInfinity);
            BottomLeftBound = new MathVector(double.PositiveInfinity, double.PositiveInfinity);

            for (int i = 0; i < lines.Length; i++)
            {
                var matches = new Regex(@"\d+").Matches(lines[i]);  // находит все совпадения, где одна или более чисел
                if (matches.Count > 1)
                {
                    double x = double.Parse(matches[0].Value); //строку в число типа double
                    double y = double.Parse(matches[1].Value);
                    _points[i] = new MathVector(x, y);
                    ModifyBounds(x, y); // регулируем границы 
                }
            }
        }

        public MathVector[] PerformClasterization(int clusterCount, int iterationCount, Action<MathVector[]> callback = null)
        {
            ShuffleCentroids(clusterCount); // перемешать центроиды (заполнить их рандомными данными)

            for (int i = 0; i < iterationCount; i++)
            {
                foreach (var point in Points) // итерируемся по всем точкам
                {
                    MathVector closestCentroid = null;
                    double minDistance = double.PositiveInfinity;

                    foreach (var centroid in _centroids)
                    {
                        double distance = centroid.CalcDistance(point); //вычисляем евклидово расстояние между точками

                        if (distance < minDistance)
                        {
                            minDistance = distance;
                            closestCentroid = centroid;
                        }
                    }

                    closestCentroid[0] = (point[0] + closestCentroid[0]) / 2;
                    closestCentroid[1] = (point[1] + closestCentroid[1]) / 2;
                }

                if (callback != null)
                    callback(_centroids);
            }

            return _centroids;
        }

        private void ShuffleCentroids(int clusterCount)
        {
            _centroids = new MathVector[clusterCount];

            for (int i = 0; i < _centroids.Length; i++)
            {
                double x = RandomDouble(BottomLeftBound[0], TopRightBound[0]);
                double y = RandomDouble(BottomLeftBound[1], TopRightBound[1]);
                _centroids[i] = new MathVector(x, y);
            }
        }

        private double RandomDouble(double min, double max)
        {
            return _random.NextDouble() * (max - min) + min;
        }

        private void ModifyBounds(double currentX, double currentY)
        {
            if (currentX > TopRightBound[0])
                TopRightBound[0] = currentX;
            if (currentX < BottomLeftBound[0])
                BottomLeftBound[0] = currentX;
            if (currentY > TopRightBound[1])
                TopRightBound[1] = currentY;
            if (currentY < BottomLeftBound[1])
                BottomLeftBound[1] = currentY;
        }
    }
}
