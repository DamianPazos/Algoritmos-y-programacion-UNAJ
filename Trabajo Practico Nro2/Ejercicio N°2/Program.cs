using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_2
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             * Analice la siguiente porción de código para calcular la sumatoria de 1 a 10. ¿Cuál es el error? ¿Qué hace realmente?
             * int sum=0; 
             * int i=1;
             * while (i<=10); 
             * { 
             * sum += i++;
             * }
             */

            // Resolucion

            int sum = 0; 
            int i = 1;
            while (i != 11) // En este sector se encuentra un ; que genera que la sentencia while se quede sin su bloque de codigo
            {
                sum += i++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
