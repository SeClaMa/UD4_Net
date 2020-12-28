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
                // Utilizo Equals para que aunque se escriba con mayus o minusuclas los dias, es igualmente identificado
                if (String.Equals( Dia, "lunes", StringComparison.CurrentCultureIgnoreCase) || 
                    String.Equals( Dia, "martes", StringComparison.CurrentCultureIgnoreCase) ||
                    String.Equals( Dia, "miercoles", StringComparison.CurrentCultureIgnoreCase) ||
                    String.Equals( Dia, "jueves", StringComparison.CurrentCultureIgnoreCase) ||
                    String.Equals( Dia, "viernes", StringComparison.CurrentCultureIgnoreCase))
                {
                    Console.WriteLine("No es fin de semana");

            }   
                else if(String.Equals(Dia, "sabado", StringComparison.CurrentCultureIgnoreCase) ||
                    String.Equals(Dia, "domingo", StringComparison.CurrentCultureIgnoreCase))
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
