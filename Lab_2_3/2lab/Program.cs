using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём вектор
            List<double> coordinates = new List<double>() { 5, 7, -3 };
            MathVector vector1 = new MathVector (coordinates);
            // Выводим его рамерность
            Console.Write("Размерность вектора: ", vector1.Dimensions); // Почему не выводится?
            Console.WriteLine(vector1.Dimensions);
            // Получаем значение координаты по индексу
            Console.Write("2я координата: ");
            Console.WriteLine(vector1[1]);
            // Изменяем значение 2й координаты на 7
            vector1[1] = 7;
            Console.Write("Изменённая 2я координата: ");
            Console.WriteLine(vector1[1]);
            // Получаем длину вектора
            Console.Write("Длина вектора: ");
            Console.WriteLine(vector1.Length);
            // Складываем координаты вектора с числом
            Console.Write("Изменённая 2я координата, когда покомпонентно складываем вектор с числом 2: ");
            Console.WriteLine(vector1.SumNumber(2)[1]);
            vector1.Evidence();
            // Умножаем координаты вектора на число
            Console.Write("Изменённая 2я координата, когда покомпонентно умножаем вектор на число: ");
            Console.WriteLine(vector1.MultiplyNumber(2)[1]);
            vector1.Evidence();
            // Складываем 2 вектора
            List<double> coordinates2 = new List<double>() { 1, 5, 1 };
            MathVector vector2 = new MathVector(coordinates2);
            Console.Write("Изменённая 2я координата, когда складываем 2 вектора: ");
            Console.WriteLine(vector1.Sum(vector2)[1]);
            vector1.Evidence();
            // Умножаем 2 вектора скалярно
            Console.Write("Скалярное произведение: ");
            Console.WriteLine(vector1.ScalarMultiply(vector2));
            vector1.Evidence();
            // Умножаем 2 вектора покомпонентно
            Console.Write("Изменённая 2я координата, когда покомпонентно умножаем 2 вектора: ");
            Console.WriteLine(vector1.Multiply(vector2)[1]);
            vector1.Evidence();
            // Умножаем вектор на число 2
            Console.Write("Изменённая 2я координата, когда умножаем вектор на 2: ");
            Console.WriteLine(vector1.Multiply(2)[1]);
            vector1.Evidence();
            // Высчитываем Евклидово расстояние
            Console.Write("Евклидово расстояние: ");
            Console.WriteLine(vector1.CalcDistance(vector2));
            vector1.Evidence();

            Console.WriteLine("ОПЕРАТОРЫ");

            // Оператор +
            Console.Write("Вторая координата от сложения векторов: ");
            Console.WriteLine((vector1 + vector2)[1]);
            vector1.Evidence();

            Console.Write("Вторая координата от сложения вектора с числом 2: ");
            Console.WriteLine((vector1 + 2)[1]);
            vector1.Evidence();
            // Оператор -
            Console.Write("Вторая координата от вычитания векторов: ");
            Console.WriteLine((vector1 - vector2)[1]);
            vector1.Evidence();

            Console.Write("Вторая координата от вычитания из вектора числа 2: ");
            Console.WriteLine((vector1 - 2)[1]);
            vector1.Evidence();
            // Оператор *
            Console.Write("Вторая координата от покомпонентного умножения векторов: ");
            Console.WriteLine((vector1 * vector2)[1]);
            vector1.Evidence();

            Console.Write("Вторая координата от умножения вектора на число 2: ");
            Console.WriteLine((vector1 * 2)[1]);
            vector1.Evidence();
            // Оператор /
            Console.Write("Вторая координата от деления вектора на число 2: ");
            Console.WriteLine((vector1 / 2)[1]);
            vector1.Evidence();
            // Оператор %
            Console.Write("Скалярное произведение векторов: ");
            Console.WriteLine(vector1 % vector2);
            vector1.Evidence();

            Console.ReadKey();
        }
    }
}
