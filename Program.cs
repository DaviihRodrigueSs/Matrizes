using System.Collections.Concurrent;
using System.Globalization;
namespace Matrizes1
{
    class program
    {
        static void Main(string[] args)
        {
            //indicação de um arranjo bidimensional [,]

            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);

            Console.WriteLine((mat.Rank));

            Console.WriteLine(mat.GetLength(0));

            Console.WriteLine(mat.GetLength(1));
        }
    }
}