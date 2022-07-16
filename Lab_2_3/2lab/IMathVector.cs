using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _2lab
{
    /// <summary>Интерфейс, содержащий методы для работы с векторами.</summary>
    public interface IMathVector
    {
        /// <summary>Получить размерность вектора.</summary>
        int Dimensions { get; }
        /// <summary>Индексатор для доступа к элементам вектора. Нумерация с нуля.</summary>
        double this[int i] { get; set; }

        /// <summary>Рассчитать длину вектора.</summary>
        double Length { get; }

        /// <summary>Получить список координат вектора.</summary>
        List<double> GetCoordinates();

        /// <summary>Покомпонентное сложение с числом.</summary>
        IMathVector SumNumber(double number);

        /// <summary>Покомпонентное умножение на число.</summary>
        IMathVector MultiplyNumber(double number);

        /// <summary>Сложение с другим вектором.</summary>
        IMathVector Sum(IMathVector vector);

        /// <summary>Покомпонентное умножение с другим вектором.</summary>
        IMathVector Multiply(IMathVector vector);

        /// <summary>Покомпонентное умножение на число.</summary>
        IMathVector Multiply(int number);

        /// <summary>Скалярное умножение с другим вектором.</summary>
        double ScalarMultiply(IMathVector vector);

        /// <summary>Вычислить Евклидово расстояние до другого вектора.</summary>
        double CalcDistance(IMathVector vector);
    }
}
