using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escriba su nombre: ");
            String Nombre = Console.ReadLine();

            Console.WriteLine("Escriba su edad: ");
            int Edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Te llamas {0} y tienes {1} años de edad.", Nombre, Edad);
        }
    }
    }

