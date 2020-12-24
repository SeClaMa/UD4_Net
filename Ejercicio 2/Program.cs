using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Escriba su nombre: ");
            String Nombre = Console.ReadLine();

            Console.WriteLine("Escriba su ciudad: ");
            String Ciudad = Console.ReadLine();

            Console.WriteLine("Hola {0}, bienvenido a {1}.",Nombre, Ciudad);
        }
    }
}
