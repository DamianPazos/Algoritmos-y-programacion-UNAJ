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
             * ¿Cuál es el problema del código siguiente y cómo se soluciona? 
             * int i=0;
             * for(int i=1;i<=10;) {
             *      Console.WriteLine(i++); 
             *                      }
             * Console.ReadKey();
            */

            // Resolucion de consigna

            for (int i=1;i<=10;i++) // Declaro e inicializo la variable 'i' con el valor correspondiente - Ademas le agrego el parametro que utiliza el for que faltaba
            {
                Console.WriteLine(i); // Le quito la suma
            }
            Console.ReadKey();
        }
    }
}
