using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab
{
    /// <summary>Класс, реализующий методы работы с векторами.</summary>
    public class MathVector : IMathVector
    {
        private List<double> _coordinates = new List<double>();

        public MathVector(int b)
        {
            for (int i = 0; i < b; i++)
            {
                _coordinates.Add(0);
            }
        }

        public MathVector(IEnumerable<double> coordinates)
        {
            _coordinates.AddRange(coordinates);
        }

        public MathVector(IMathVector vector)
        {
            for (int i = 0; i < vector.Dimensions; i++)
                _coordinates.Add(vector[i]);
        }

        /// <summary>Получить размерность вектора.</summary>
        /// <return>Размерность вектора.</return>
        public int Dimensions
        {
            get
            {
                return _coordinates.Count;
            }
        }

        public void Evidence()
        {
            Console.WriteLine("Для доказательства иммутабельности выведем координаты вектора: ");
            for (int i = 0; i < _coordinates.Count; i++)
            {
                Console.Write(_coordinates[i]);
                Console.WriteLine(' ');
            }
        }

        /// <summary>Получить/установить координату вектора по индексу.</summary>
        /// <return>Координата вектора по индексу.</return>
        public double this[int i]
        {
            get
            {
                if ((i >= 0) && (i < Dimensions))
                    return _coordinates[i];
                else
                    throw new ArgumentOutOfRangeException();
            }
            set
            {
                if ((i >= 0) && (i < Dimensions))
                    _coordinates[i] = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>Получить длину вектора.</summary>
        /// <return>Длина вектора.</return>
        public double Length
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < Dimensions; i++)
                {
                    sum += Math.Pow(this[i], 2);
                }
                return Math.Pow(sum, 0.5);
            }
        }

        /// <summary>Получить список координат вектора.</summary>
        /// <return>Список координат вектора.</return>
        public List<double> GetCoordinates()
        {
            return new List<double>(_coordinates);
        }

        /// <summary>Покомпонентно сложить вектор с числом.</summary>
        /// <param name="number">Число, которое прибавится к каждой координате вектора.</param>
        /// <return>Новый вектор, координаты которого являются результатом покомпонентного сложения вектора с числом.</return>
        public IMathVector SumNumber(double number)
        {
            MathVector vector = new MathVector(_coordinates);
            for (int i = 0; i < Dimensions; i++)
            {
                vector[i] += number;
            }
            return vector;
        }

        /// <summary>Покомпонентно умножить вектор на число.</summary>
        /// <param name="number">Число, на которое умножится каждая координата вектора.</param>
        /// <return>Новый вектор, координаты которого являются результатом покомпонентного умножения вектора на число.</return>
        public IMathVector MultiplyNumber(double number)
        {
            MathVector vector = new MathVector(_coordinates);
            for (int i = 0; i < Dimensions; i++)
            {
                vector[i] *= number;
            }
            return vector;
        }

        /// <summary>Покомпонентно сложить вектор с вектором.</summary>
        /// <param name="vector">Объект интерфейса IMathVector, координаты которого прибавятся к координатам вектора.</param>
        /// <exception cref="VectorExceptions"></exception>
        /// <return>Новый вектор, координаты которого являются результатом покомпонентного сложения координат векторов.</return>
        public IMathVector Sum(IMathVector vector)
        {
            MathVector total_vector = new MathVector(_coordinates);
            if (total_vector.Dimensions == vector.Dimensions)
                for (int i = 0; i < Dimensions; i++)
                {
                    total_vector[i] += vector[i];
                }
            else
                throw new VectorException(Dimensions, vector.Dimensions);
            return total_vector;
        }

        /// <summary>Скалярно умножить векторы.</summary>
        /// <param name="vector">Объект интерфейса IMathVector, координаты которого будут использованы для поиска скалярного произведения с вектором.</param>
        /// <exception cref="VectorExceptions"></exception>
        /// <return>Вещественное число, являющееся скалярным произведением векторов.</return>
        public double ScalarMultiply(IMathVector vector)
        {
            double Scalarmultiply = 0;
            if (Dimensions == vector.Dimensions)
                for (int i = 0; i < Dimensions; i++)
                {
                    Scalarmultiply += this[i] * vector[i];
                }
            else
                throw new VectorException(Dimensions, vector.Dimensions);
            return Scalarmultiply;
        }

        /// <summary>Покомпонентно умножить векторы.</summary>
        /// <param name="vector">Объект интерфейса IMathVector, на координаты которого домножатся координаты вектора.</param>
        /// <exception cref="VectorExceptions"></exception>
        /// <return>Новый вектор, координаты которого являются результатом покомпонентного умножения координат векторов.</return>
        public IMathVector Multiply(IMathVector vector)
        {
            MathVector total_vector = new MathVector(_coordinates);
            if (total_vector.Dimensions == vector.Dimensions)
                for (int i = 0; i < Dimensions; i++)
                {
                    total_vector[i] *= vector[i];
                }
            else
                throw new VectorException(Dimensions, vector.Dimensions);
            return total_vector;
        }

        /// <summary>Покомпонентно умножить вектор на число.</summary>
        /// <param name="number">Число, на которое умножится каждая координата вектора.</param>
        /// <return>Новый вектор, координаты которого являются результатом покомпонентного умножения координат вектора на число.</return>
        public IMathVector Multiply(int number)
        {
            MathVector total_vector = new MathVector(_coordinates);
            for (int i = 0; i < Dimensions; i++)
            {
                total_vector[i] *= number;
            }
            return total_vector;
        }

        /// <summary>Вычислить Евклидово расстояние между векторами.</summary>
        /// <param name="vector">Объект интерфейса IMathVector, который нужен для вычисления расстояния между ним и вектором.</param>
        /// <exception cref="VectorExceptions"></exception>
        /// <return>Число, показывающее Евклидово расстояние между векторами.</return>
        public double CalcDistance(IMathVector vector)
        {
            double sum = 0;
            if (Dimensions == vector.Dimensions)
                for (int i = 0; i < Dimensions; i++)
                {
                    sum += Math.Pow(this[i] - vector[i], 2);
                }
            else
                throw new VectorException(Dimensions, vector.Dimensions);
            return Math.Pow(sum, 0.5);
        }



        //////////////////////////////Перегрузки операторов//////////////////////////////



        /// <summary>Покомпонентно сложить векторы.</summary>
        /// <param name="vector1">Объект класса MathVector, координаты которого сложатся с координатами другого вектора.</param>
        /// <param name="vector2">Объект класса MathVector, координаты которого сложатся с координатами другого вектора.</param>
        /// <exception cref="VectorExceptions"></exception>
        /// <returns>Новый вектор, являющийся результатом покомпонентного сложения векторов.</returns>
        public static MathVector operator +(MathVector vector1, MathVector vector2)
        {
            return new MathVector(vector1.Sum(vector2));
        }

        /// <summary>Покомпонентно сложить вектор с числом.</summary>
        /// <param name="vector1">Объект класса MathVector, координаты которого сложатся с числом.</param>
        /// <param name="number">Число, которое прибавится к каждой координате вектора.</param>
        /// <returns>Новый вектор, являющийся результатом покомпонентного сложения вектора с числом.</returns>
        public static MathVector operator +(MathVector vector1, double number)
        {
            return new MathVector(vector1.SumNumber(number));
        }

        /// <summary>Покомпонентно вычесть векторы.</summary>
        /// <param name="vector1">Объект класса MathVector, координаты которого уменьшатся в результате вычитания с координатами другого вектора.</param>
        /// <param name="vector2">Объект класса MathVector, координаты которого будут вычитаться из координат другого вектора.</param>
        /// <exception cref="VectorExceptions"></exception>
        /// <returns>Новый вектор, являющийся результатом покомпонентного вычитания векторов.</returns>
        public static MathVector operator -(MathVector vector1, MathVector vector2)
        {
            if (vector1.Dimensions == vector2.Dimensions)
            {
                MathVector total_vector = new MathVector(vector1);
                for (int i = 0; i < total_vector.Dimensions; i++)
                {
                    total_vector[i] -= vector2[i];
                }
                return total_vector;
            }
            else
                throw new VectorException(vector1.Dimensions, vector2.Dimensions);
        }

        /// <summary>Покомпонентно вычесть из вектора число.</summary>
        /// <param name="vector1">Объект класса MathVector, координаты которого уменьшатся в результате вычитания с числом.</param>
        /// <param name="number">Число, которое будет вычитаться из координат вектора.</param>
        /// <returns>Новый вектор, являющийся результатом покомпонентного вычитания числа из вектора.</returns>
        public static MathVector operator -(MathVector vector1, double number)
        {
            return new MathVector(vector1.SumNumber(-number));
        }

        /// <summary>Покомпонентно умножить векторы.</summary>
        /// <param name="vector1">Объект класса MathVector, координаты которого умножатся с координатами другого вектора.</param>
        /// <param name="vector2">Объект класса MathVector, координаты которого умножатся с координатами другого вектора.</param>
        /// <exception cref="VectorExceptions"></exception>
        /// <returns>Новый вектор, являющийся результатом покомпонентного умножения векторов.</returns>
        public static MathVector operator *(MathVector vector1, MathVector vector2)
        {
            return new MathVector(vector1.Multiply(vector2));
        }

        /// <summary>Покомпонентно умножить вектор на число.</summary>
        /// <param name="vector1">Объект класса MathVector, координаты которого умножатся на число.</param>
        /// <param name="number">Число, которое будет умножено на координаты вектора.</param>
        /// <returns>Новый вектор, являющийся результатом покомпонентного умножения вектора на число.</returns>
        public static MathVector operator *(MathVector vector1, double number)
        {
            return new MathVector(vector1.MultiplyNumber(number));
        }

        /// <summary>Покомпонентно разделить вектор на число.</summary>
        /// <param name="vector1">Объект класса MathVector, координаты которого разделятся на число.</param>
        /// <param name="number">Число, на которое будут разделены координаты вектора.</param>
        /// <returns>Новый вектор, являющийся результатом покомпонентного деления вектора на число.</returns>
        public static MathVector operator /(MathVector vector1, double number)
        {
            return new MathVector(vector1.MultiplyNumber(1 / number));
        }

        /// <summary>Скалярно умножить векторы.</summary>
        /// <param name="vector1">Объект класса MathVector, координаты которого скалярно умножатся с координатами другого вектора.</param>
        /// <param name="vector2">Объект класса MathVector, координаты которого скалярно умножатся с координатами другого вектора.</param>
        /// <exception cref="VectorExceptions"></exception>
        /// <returns>Вещественное число, являющееся результатом скалярного умножения векторов.</returns>
        public static double operator %(MathVector vector1, MathVector vector2)
        {
            return vector1.ScalarMultiply(vector2);
        }
    }
}
