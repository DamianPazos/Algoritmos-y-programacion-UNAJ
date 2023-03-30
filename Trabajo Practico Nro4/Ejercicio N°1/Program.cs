using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_1
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             * Codifique la clase Hora de tal forma que al ejecutar el siguiente programa de aplicación 
             * (Main): 
             * class Program
             * {
             *      public static void Main(string[] args)
             *      {
             *           Hora h=new Hora(23,30,15); 
             *           h.imprimir(); 
             *           Console.ReadKey(true);
             *      }
             * }
             * se imprima por consola: 23 HORAS, 30 MINUTOS Y 15 SEGUNDOS
             */

            // Programa dado por el ejercicio
            Hora h = new Hora(23, 30, 15);
            h.imprimir();
            Console.ReadKey(true);

        }
    }
}
