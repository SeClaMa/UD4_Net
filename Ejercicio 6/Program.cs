using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Precio;
            
            do
            {
                Console.WriteLine("Inserte el precio del producto: ");

                Precio = Convert.ToInt32(Console.ReadLine());
                
                //Al introducir el precio no he podido obligar al usuario a que sea numero y no string
                //Se necesita investigar mas el toString
                                              
                Boolean Forma = false;

                //He usado un Bollean para identificar si la forma de pago es correcta
                
                
                    do
                    {
                        if (Precio > 0)
                        {
                            Console.WriteLine("Inserte la forma de pago: ");
                            String Pago = Console.ReadLine();

                            switch (Pago.ToLower())
                            {
                                case "efectivo":

                                    Console.WriteLine("Usted a puesto un precio de {0}, con pago en efectivo", Precio);
                                    Forma = true;
                                    break;

                                case "tarjeta":
                                    Console.WriteLine("Por favor, inserte el numero de tarjeta: ");

                                    int tarjeta = Convert.ToInt32(Console.ReadLine());

                                    if (tarjeta > 0)
                                    {
                                        Console.WriteLine("Usted a puesto un precio de {0}, con el numero de tarjeta {1}", Precio, tarjeta);
                                        Forma = true;
                                    }

                                    break;

                                default:
                                    Console.WriteLine("La forma de pago no es correcta, vuelva a intentarlo con efectivo o tarjeta");
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("El precio indicado es negativo, vuelva a introducir un precio positivo");
                            Forma = true;
                        }
                    } while (Forma == false);
                
                    
                  


            } while (Precio < 0);

            Console.WriteLine("Gracias por la compra.");
            
           
                
      
            
        }
    }
}
