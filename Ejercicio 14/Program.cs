using System;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, area;
            Console.Write("Escriba el radio del circulo : ");
            r = Convert.ToDouble(Console.ReadLine());
            //area = 3.14 * r * r;    
            area = Math.PI * Math.Pow(r, 2);      
            Console.WriteLine("El area del circulo es : {0}", area);
            Console.ReadKey();
        }
    }
}
