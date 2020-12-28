using System;

namespace Ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
            String Contra = "H0la";
            

            
            int intentos = 1;
            int repe = 4;
            do
            {               
                Console.WriteLine("Introduzca la contraseña: ");
                String resp = Console.ReadLine();
                if (String.Equals(Contra, resp))
                {
                    Console.WriteLine("Enhorabuena, bienvenido");
                    intentos = 3;
                }
                else
                {
                    --repe;
                    Console.WriteLine("Contraseña erronea, vuelva a intentarlo, tiene {0} intentos mas",repe-1);

                }            
                intentos++;
            } while (intentos<=3);
            
        }
    }
}
