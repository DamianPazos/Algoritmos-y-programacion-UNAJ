using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_3
{
    public class Program
    {

        /*
         * Escriba un programa de aplicación que calcule la suma de dos números reales introducidos por teclado y muestre
         * el resultado en la consola. 
         * Ayuda: utilice Double.Parse(st) para obtener el valor real del string st. 
        */

        static void Main(string[] args)
        {

            // Variables
            double dblNumero1;
            double dblNumero2;
            double dblResultado;

            // Resolucion
            Console.Write("Ingrese el primer numero: ");
            dblNumero1 = double.Parse(Console.ReadLine()); // Ingreso del primer numero

            Console.Write("Ingrese el segundo numero: ");
            dblNumero2 = double.Parse(Console.ReadLine()); // Ingreso del segundo numero

            dblResultado = dblNumero1 + dblNumero2; // Se desarrolla el calculo

            //Resultado
            Console.WriteLine(dblResultado); // Se devuelve el resultado
            Console.ReadKey(); // Pausa
        }
    }
}
