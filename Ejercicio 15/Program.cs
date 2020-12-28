using System;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Por favor, indique el numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("Es divisible entre 2");
            }else if (num1 % 2 !=0 )
            {
                Console.WriteLine("No es divisible entre 2");
            }

        }
    }
}
