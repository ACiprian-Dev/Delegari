using System;

namespace Delegari
{
    internal class Program
    {
        private delegate void afis_op(int a, int b);

        private static void sum(int a, int b)
        {
            Console.WriteLine("Suma numerelor {0} si {1} este {2}", a, b, a + b);
        }

        private static void dif(int a, int b)
        { 
            Console.WriteLine("Diferenta numerelor {0} si {1} este {2}", a, b, a - b);
        }

        private static void prod(int a, int b)
        { 
            Console.WriteLine("Produsul numerelor {0} si {1} este {2}", a, b, a * b);
        }

        private static void Main(string[] args)
        {
            afis_op f;
            f = sum;
            f = f + dif + prod;
            f(3, 5);
            Console.ReadKey();
            f = f - dif;
            f(10, 7);
            Console.ReadKey();
        }
    }
}