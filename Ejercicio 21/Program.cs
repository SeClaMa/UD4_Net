using System;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el dia de la semana: ");
            String  Dia = Console.ReadLine();

            
            switch (Dia.ToLower())
            {
                case "lunes":
                    Console.WriteLine("Es dia Laboral");
                    break;
                case "martes":
                    Console.WriteLine("Es dia Laboral");
                    break;
                case "miercoles":
                    Console.WriteLine("Es dia Laboral");
                    break;
                case "jueves":
                    Console.WriteLine("Es dia Laboral");
                    break;
                case "viernes":
                    Console.WriteLine("Es dia Laboral");
                    break;
                case "sabado":
                    Console.WriteLine("No es dia Laboral");
                    break;
                case "domingo":
                    Console.WriteLine("No es dia Laboral");
                    break;

                default:
                    Console.WriteLine("No ha indicado el dia correctamente, nulo");
                    break;
            }
        }
    }
}
