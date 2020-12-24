using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine("Este numero es par o divisible entre 3, {0}", i);
                }

            }
        }
    }
}
