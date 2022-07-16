using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab
{
    public class VectorException : Exception
    {
        /// <summary>Исключение при работе с векторами разной размерности.</summary>
        public VectorException()
            : base("Исключение: работа с векторами разной размерности невозможна")
        { }

        /// <summary>Исключение при работе с векторами разной размерности с указанием этих размерностей.</summary>
        /// <param name="dimension1">Размерность первого вектора.</param>
        /// <param name="dimension2">Размерность второго вектора.</param>
        public VectorException(int dimension1, int dimension2)
            : base("Исключение: работа с векторами размерностей " + dimension1 + " и " + dimension2 + " соотвественно невозможна")
        { }

        /// <summary>Исключение при работе с векторами разной размерности с выводом собственного сообщения.</summary>
        /// <param name="message">Сообщение для исключения.</param>
        public VectorException(string message)
            : base(message)
        { }

        /// <summary>Исключение при работе с векторами разной размерности с выводом собственного сообщения и ссылкой на внутреннее исключение, вызвавшее данное исключение .</summary>
        /// <param name="message">Сообщение для исключения.</param>
        /// <param name="innerException">Исключение, вызвавшее текущее исключение. </param>
        public VectorException(string message, Exception innerException)
        : base(message, innerException)
        { }
    }
}
