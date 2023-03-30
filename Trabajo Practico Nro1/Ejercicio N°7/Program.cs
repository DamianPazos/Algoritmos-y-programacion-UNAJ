using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_7
{
    public class Program
    {

        /*
         * Implemente un programa de aplicación que permita al usuario ingresar números por la consola. A medida que 
         * se van ingresando los valores el sistema debe mostrar por la consola la suma acumulada de los mismos. El 
         * proceso termina cuando se ingresa un 0. Informar al final la cantidad total de números ingresados y sumados.
         */

        static void Main(string[] args)
        {

            int intNumero; // Se declara el numero de ingreso
            int intSuma = 0; // Se declara e inicializa la suma
            int intContador = 0; // Se declara e inicializa el contador
            bool boolBandera = true; // Se declara e inicializa la bandera del while

            while (boolBandera) // Mientras el numero ingresado no sea 0, se sigue ingresando numeros
            {
                Console.Write("Ingrese un numero: ");
                intNumero = int.Parse(Console.ReadLine()); // Se ingresa el numero
                intSuma += intNumero; // Se realiza la suma
                intContador++; // Se incrementa el contador
                Console.WriteLine($"La suma parcial de los numeros ingresados es: {intSuma}"); // Se devuelve la suma parcial
                Console.ReadKey(); // Pausa
                Console.Clear(); // Limpieza de consola

                if (intNumero == 0) // Si se ingresa 0 se cambia el estado de la bandera
                {
                    boolBandera = false; // Cambia la condicion de la bandera
                }
            }

            Console.WriteLine($"La suma total es: {intSuma}\nEl numero de valores ingresados es: {intContador}"); // Se devuelve la suma total y la cantidad de numeros ingresados
            Console.ReadKey(); // Pausa

        }
    }
}
