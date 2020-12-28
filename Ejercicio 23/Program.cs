using System;

namespace Ejercicio_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el signo aritmetico: ");
            char signo = Convert.ToChar(Console.ReadLine());

            switch (signo)
            {
                case '+':
                    Console.WriteLine("La suma de los numeros es: {0}", num1 + num2);
                    break;
                case '-':
                    Console.WriteLine("La resta de los numeros es: {0}", num1 - num2);
                    break;
                case '*':
                    Console.WriteLine("La multiplicacion de los numeros es: {0}", num1 * num2);
                    break;
                case '/':
                    double divide1 = Convert.ToDouble(num1);
                    double divide2 = Convert.ToDouble(num2);
                    Console.WriteLine("La division de los numeros es: {0}", divide1/divide2);
                    break;
                case '^':
                    Console.WriteLine("El operado de los numeros es: {0}", Math.Pow(num1,num2));
                    break;
                case '%':
                    Console.WriteLine("El modulo de los numeros es: {0}", num1 %  num2);
                    break;

                default:
                    Console.WriteLine("Signo incorrecto");
                    break;
            }
        }
    }
}
