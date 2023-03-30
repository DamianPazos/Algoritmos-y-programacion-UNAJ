using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_4
{
    internal class Program
    {
        /*
         * Escriba un programa de aplicación que solicite al usuario que ingrese un número de mes (1 a 12) e imprima el
         * nombre 
         * del mes correspondiente. Si el valor ingresado no está en ese rango debe imprimir “Mes inválido ” . Utilice la 
         * sentencia switch.
         */

        static void Main(string[] args)
        {

            // Variables
            int intMes;

            // Resolucion y Resultado
            Console.WriteLine("Ingrese el numero del mes: ");
            intMes = int.Parse(Console.ReadLine()); // Se ingresa el mes a imprimir

            switch (intMes) // Dependiendo del numero del mes ingresado se devuelve el mes correspondiente
            {
                case 1:
                    Console.WriteLine("Enero");
                    break;
                case 2:
                    Console.WriteLine("Febrero");
                    break;
                case 3:
                    Console.WriteLine("Marzo");
                    break;
                case 4:
                    Console.WriteLine("Abril");
                    break;
                case 5:
                    Console.WriteLine("Mayo");
                    break;
                case 6:
                    Console.WriteLine("Junio");
                    break;
                case 7:
                    Console.WriteLine("Julio");
                    break;
                case 8:
                    Console.WriteLine("Agosto");
                    break;
                case 9:
                    Console.WriteLine("Septiembre");
                    break;
                case 10:
                    Console.WriteLine("Octubre");
                    break;
                case 11:
                    Console.WriteLine("Noviembre");
                    break;
                case 12:
                    Console.WriteLine("Diciembre");
                    break;
                default:
                    Console.WriteLine("Mes invalido");
                    break;
            }

            Console.ReadKey(); // Pausa
        }
    }
}
