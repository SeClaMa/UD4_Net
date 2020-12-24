using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indique el dia de la semana: ");
            var  Dia = Console.ReadLine();

            try
            {
                // Utilizo Compare para que aunque se escriba con mayus o minusuclas los dias, es igualmente identificado
                if (String.Compare( Dia, "lunes", true)== 0 || 
                    String.Compare( Dia, "martes", true) == 0 ||
                    String.Compare( Dia, "miercoles", true) == 0 ||
                    String.Compare( Dia, "jueves", true) == 0 ||
                    String.Compare( Dia, "viernes", true) == 0)
                {
                    Console.WriteLine("No es fin de semana");

            }   
                else if(String.Compare(Dia, "sabado", true)== 0 ||
                    String.Compare(Dia, "domingo", true)==0)
                {
                    Console.WriteLine("Es fin de semana");
                }
                else
                {
                    Console.WriteLine("No es un dia");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            
        }
    }
}
