using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;

            Console.WriteLine("Introduzca el primer numero: ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo numero: ");
            Num2 = Convert.ToInt32(Console.ReadLine());


            if (Num1>Num2)
            {
                Console.WriteLine("{0} es mayor que {1}",Num1,Num2);
            }else if (Num2 > Num1)
            {
                Console.WriteLine("{0} es mayor que {1}", Num2, Num1);
            }
            else if(Num1==Num2 || Num2 == Num1)
            {
                Console.WriteLine("Los dos numeros son iguales");
            }
         
            


        }
    }
}
