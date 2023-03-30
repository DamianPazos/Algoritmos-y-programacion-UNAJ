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
             * Agregue un segundo constructor a la clase Hora para que pueda recibir la hora en un solo parámetro de 
             * clase string. Así el siguiente código:
             * class Program
             * {
             * public static void Main(string[] args)
             *  {
             *      Hora h1=new Hora(23,30,15); 
             *      Hora h2=new Hora("14:25:47"); 
             *      h1.imprimir();
             *      h2.imprimir(); 
             *      Console.ReadKey(true);
             *  }
             * }
             * produce la siguiente salida por consola:
             * 23 HORAS, 30 MINUTOS Y 15 SEGUNDOS
             * 14 HORAS, 25 MINUTOS Y 47 SEGUNDOS
             */

            Hora h1 = new Hora(23, 30, 15);
            Hora h2 = new Hora("14:25:47");
            h1.imprimir();
            h2.imprimir();
            Console.ReadKey(true);

        }
    }
}
