using System;

namespace Demographic.FileOperations
{
    public class AgeStatistics
    {
        // автосвойства - удобно, не нужно прописывать все поля по отдельности (сделает компилятор)
        public int Age { get; private set; } // может быть назначено внутри класса, но снаружи только считано
        public float RelativeAmount { get; private set; }

        public AgeStatistics(int age, float relativeAmount)
        {
            Age = age;
            RelativeAmount = relativeAmount;
        }
    }
}
