using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el primer numero: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba el segundo numero: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());

           
            if (Num1 > Num2)
            {
                Console.WriteLine("El numero {0} es mayor que {1}", Num1, Num2);
            }
            else if (Num2 > Num1) {
                Console.WriteLine("El numero {0} es mayor que {1}", Num2, Num1);
            }


        }
    }
}
