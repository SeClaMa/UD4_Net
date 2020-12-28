using System;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i%2==0 && i%3==0)
                {
                    Console.WriteLine("Este numero es divisible entre 2 y 3: {0} ",i);
                }
            }
        }
    }
}
