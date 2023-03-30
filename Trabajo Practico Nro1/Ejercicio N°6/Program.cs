using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_6
{
    public class Program
    {

        /*
         * Escriba un programa de aplicación que imprima en la consola todos los números pares que además sean múltiplos 
         * de 5 y estén comprendidos entre 250 y 900.

         */

        static void Main(string[] args)
        {

            int intNumero = 250; // Se declara e inicializa con el valor

            while ((intNumero%5) == 0 && intNumero <= 900) // Mientras se cumplan con las condiciones
            {
                Console.WriteLine(intNumero); // Se devuelve el numero
                intNumero += 5; // Se incrementa de a 5
            }

            Console.ReadKey(); // Pausa

        }
    }
}
