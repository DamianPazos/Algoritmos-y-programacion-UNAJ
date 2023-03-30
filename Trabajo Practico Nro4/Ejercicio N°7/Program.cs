using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_7
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             *  Cree una clase llamada Operación con tres campos: operando1, operando2 y operador. Cada instancia creada 
             *  deberá devolver el resultado correspondiente mediante la llamada a un método evaluar que será encargado 
             *  de efectuar la operación solicitada. El programa de aplicación deberá imprimir todos los resultados 
             *  calculados. 
             *  Ejemplo:
             *  Operación op=new Operación(5,4,”+”);
             *  res=op.evaluar(); 
             *  Console.WriteLine(res); 
             */

            // Ejemplos
            Operacion op1 = new Operacion(5, 4,"+");
            double res1 = op1.evaluar();
            Console.WriteLine(res1);

            Operacion op2 = new Operacion(5, 4, "-");
            double res2 = op2.evaluar();
            Console.WriteLine(res2);

            Operacion op3 = new Operacion(5, 4, "*");
            double res3 = op3.evaluar();
            Console.WriteLine(res3);

            Operacion op4 = new Operacion(5, 4, "/");
            double res4 = op4.evaluar();
            Console.WriteLine(res4);

            Console.ReadKey(); // Pausa

        }
    }
}
