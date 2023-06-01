using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.Write("Selecciona una opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 5)
                {
                    continuar = false;
                }
                else
                {
                    Console.Write("Ingresa el primer número: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingresa el segundo número: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("El resultado es: " + (num1 + num2));
                            break;
                        case 2:
                            Console.WriteLine("El resultado es: " + (num1 - num2));
                            break;
                        case 3:
                            Console.WriteLine("El resultado es: " + (num1 * num2));
                            break;
                        case 4:
                            if (num2 != 0)
                            {
                                Console.WriteLine("El resultado es: " + (num1 / (double)num2));
                            }
                            else
                            {
                                Console.WriteLine("No se puede dividir por cero.");
                            }
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                Console.WriteLine();

            }
    }
    }
}
