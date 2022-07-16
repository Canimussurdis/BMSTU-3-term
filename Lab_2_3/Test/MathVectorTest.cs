using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2lab;

namespace Test
{
    [TestClass]
    public class MathVectorTest
    {
        [TestMethod]
        public void TestLength1() // Нормальный вариант
        {
            // arrange
            MathVector vector = new MathVector(new List<double>() { 5, 7, -3 });

            // act
            double length = vector.Length;

            // assert
            Assert.AreEqual(9.1104335791443, length);
        }

        [TestMethod]
        public void TestLength2() // Все координаты по нулям
        {
            // arrange
            MathVector vector = new MathVector(new List<double>() { 0, 0, 0, 0 });

            // act
            double length = vector.Length;

            // assert
            Assert.AreEqual(0, length);
        }

        [TestMethod]
        public void TestLength3() // Не поступает координат
        {
            // arrange
            MathVector vector = new MathVector(4);

            // act
            double length = vector.Length;

            // assert
            Assert.AreEqual(0, length);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void TestGetCoordinates1() // Не поступает координат
        {
            // arrange
            MathVector vector = new MathVector(4);
            List<double> list1 = new List<double>() { 0, 0, 0, 0 };

            // act
            List<double> list2 = vector.GetCoordinates();

            // assert
            CollectionAssert.AreEqual(list1, list2);
        }

        [TestMethod]
        public void TestGetCoordinates2() // Поступают нормальные координаты
        {
            // arrange
            List<double> list1 = new List<double>() { -9.3, 15, 0.98, -1 };
            MathVector vector = new MathVector(list1);

            // act
            List<double> list2 = new List<double>(vector.GetCoordinates());

            // assert
            CollectionAssert.AreEqual(list1, list2);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void SumNumber1() // Поступает нормальное число
        {
            // arrange
            MathVector vector = new MathVector(new List<double>() { 1, 2, 3 });
            double number = 3.4;

            // act 
            List<double> a = new List<double>(vector.SumNumber(number).GetCoordinates());
            List<double> b = new List<double>() { 4.4, 5.4, 6.4 };

            // assert
            CollectionAssert.AreEqual(a, b);
        }

        [TestMethod]
        public void SumNumber2() // Поступает ноль
        {
            // arrange
            MathVector vector = new MathVector(new List<double>() { 1, 2, 3 });
            double number = 0;

            // act 
            List<double> a = new List<double>(vector.SumNumber(number).GetCoordinates());
            List<double> b = new List<double>() { 1, 2, 3 };

            // assert
            CollectionAssert.AreEqual(a, b);
        }

        [TestMethod]
        public void SumNumber3() // Поступает отрицательное число
        {
            // arrange
            MathVector vector = new MathVector(new List<double>() { 2, 3, 4 });
            double number = -1.2;

            // act 
            List<double> a = new List<double>(vector.SumNumber(number).GetCoordinates());
            List<double> b = new List<double>() { 0.8, 1.8, 2.8 };

            // assert
            CollectionAssert.AreEqual(a, b);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void MultiplyNumber1() // Поступает ноль
        {
            // arrange
            MathVector vector = new MathVector(new List<double>() { 1, 2, 3 });
            double number = 0;

            // act 
            List<double> a = new List<double>(vector.MultiplyNumber(number).GetCoordinates());
            List<double> b = new List<double>() { 0, 0, 0 };

            // assert
            CollectionAssert.AreEqual(a, b);
        }

        [TestMethod]
        public void MultiplyNumber2() // Поступает отрицательное число
        {
            // arrange
            MathVector vector = new MathVector(new List<double>() { 1, 2, 3 });
            double number = -2;

            // act 
            List<double> a = new List<double>(vector.MultiplyNumber(number).GetCoordinates());
            List<double> b = new List<double>() { -2, -4, -6 };

            // assert
            CollectionAssert.AreEqual(a, b);
        }

        [TestMethod]
        public void MultiplyNumber3() // Поступает положительное число
        {
            // arrange
            MathVector vector = new MathVector(new List<double>() { 1, 2, 3 });
            double number = 200;

            // act 
            List<double> a = new List<double>(vector.MultiplyNumber(number).GetCoordinates());
            List<double> b = new List<double>() { 200, 400, 600 };

            // assert
            CollectionAssert.AreEqual(a, b);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void Sum1() // Поступает вектор другой размерности
        {
            // arrange
            MathVector vector1 = new MathVector(new List<double>() { 1, 2, 3 });
            MathVector vector2 = new MathVector(new List<double>() { 4, -2, 1.2, 4 });

            // act
            Action action = delegate ()
            {
                Console.WriteLine(vector1.Sum(vector2)[3]);
            };

            //assert
            Assert.ThrowsException<VectorException>(action);
        }

        [TestMethod]
        public void Sum2() // Поступает пустой вектор
        {
            // arrange
            MathVector vector1 = new MathVector(new List<double>() { 1, 2, 3, 4 });
            MathVector vector2 = new MathVector(4);

            // act 
            List<double> a = new List<double>(vector1.Sum(vector2).GetCoordinates());
            List<double> b = new List<double>((vector1 + vector2).GetCoordinates());

            // assert
            CollectionAssert.AreEqual(a, b);
        }

        [TestMethod]
        public void Sum3() // Поступает вектор с той же размерностью и имеющий координаты
        {
            // arrange
            MathVector vector1 = new MathVector(new List<double>() { 1, 2, 3 });
            MathVector vector2 = new MathVector(new List<double>() { 4, 5, 6 });

            // act 
            List<double> a = new List<double>(vector1.Sum(vector2).GetCoordinates());
            List<double> b = new List<double>((vector1 + vector2).GetCoordinates());

            // assert
            CollectionAssert.AreEqual(a, b);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void ScalarMultiply1() // Поступает вектор другой размерности
        {
            // arrange
            MathVector vector1 = new MathVector(new List<double>() { 5, 7, -3 });
            MathVector vector2 = new MathVector(new List<double>() { 1, 5, 1, 0 });

            // act
            Action action = delegate ()
            {
                Console.WriteLine(vector1.ScalarMultiply(vector2));
            };

            //assert
            Assert.ThrowsException<VectorException>(action);
        }

        [TestMethod]
        public void ScalarMultiply2() // Поступает пустой вектор
        {
            // arrange
            MathVector vector1 = new MathVector(new List<double>() { 1, 2, 3, 4 });
            MathVector vector2 = new MathVector(4);

            // act
            double a = vector1.ScalarMultiply(vector2);

            // assert
            Assert.AreEqual(a, 0);
        }

        [TestMethod]
        public void ScalarMultiply3() // Поступает вектор с той же размерностью и имеющий координаты
        {
            // arrange
            MathVector vector1 = new MathVector(new List<double>() { 5, 7, -3 });
            MathVector vector2 = new MathVector(new List<double>() { 1, 5, 1 });

            // act
            double a = vector1.ScalarMultiply(vector2);

            // assert
            Assert.AreEqual(a, 37);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void Multiply1() // Поступает вектор другой размерности
        {
            // arrange
            MathVector vector1 = new MathVector(new List<double>() { 1, 2, 3 });
            MathVector vector2 = new MathVector(new List<double>() { 4, -2, 1.2, 4 });

            // act
            Action action = delegate ()
            {
                Console.WriteLine(vector1.Multiply(vector2)[3]);
            };

            //assert
            Assert.ThrowsException<VectorException>(action);
        }

        [TestMethod]
        public void Multiply2() // Поступает пустой вектор
        {
            // arrange
            MathVector vector1 = new MathVector(new List<double>() { 1, 2, 3, 4 });
            MathVector vector2 = new MathVector(4);

            // act 
            List<double> a = new List<double>(vector1.Multiply(vector2).GetCoordinates());
            List<double> b = new List<double>((vector1 * vector2).GetCoordinates());

            // assert
            CollectionAssert.AreEqual(a, b);
        }

        [TestMethod]
        public void Multiply3() // Поступает вектор с той же размерностью и имеющий координаты
        {
            // arrange
            MathVector vector1 = new MathVector(new List<double>() { 1, 2, 3 });
            MathVector vector2 = new MathVector(new List<double>() { 4, 5, 6 });

            // act 
            List<double> a = new List<double>(vector1.Multiply(vector2).GetCoordinates());
            List<double> b = new List<double>((vector1 * vector2).GetCoordinates());

            // assert
            CollectionAssert.AreEqual(a, b);
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        [TestMethod]
        public void CalcDistance1() // Поступает вектор другой размерности
        {
            // arrange
            MathVector vector1 = new MathVector(new List<double>() { 5, 7, -3 });
            MathVector vector2 = new MathVector(new List<double>() { 1, 5, 1, 0 });

            // act
            Action action = delegate ()
            {
                Console.WriteLine(vector1.CalcDistance(vector2));
            };

            //assert
            Assert.ThrowsException<VectorException>(action);
        }

        [TestMethod]
        public void CalcDistance2() // Поступает пустой вектор
        {
            // arrange
            MathVector vector1 = new MathVector(new List<double>() { 2, 2, -1, 0 });
            MathVector vector2 = new MathVector(4);

            // act
            double a = vector1.CalcDistance(vector2);

            //assert
            Assert.AreEqual(a, 3);
        }

        [TestMethod]
        public void CalcDistance3() // Поступает вектор с той же размерностью и имеющий координаты
        {
            // arrange
            MathVector vector1 = new MathVector(new List<double>() { 5, 7, -3 });
            MathVector vector2 = new MathVector(new List<double>() { 1, 5, 1 });

            // act
            double a = vector1.CalcDistance(vector2);

            //assert
            Assert.AreEqual(a, 6);
        }
    }
}
