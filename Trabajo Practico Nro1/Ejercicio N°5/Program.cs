using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_5
{
    public class Program
    {

        /* Escriba un programa de aplicación que lea por teclado una secuencia de números y que imprima el valor máximo, el
         * valor mínimo de dicho conjunto y el valor promedio.
        */
        static void Main(string[] args)
        {

            // Variables
            int intNumero; // Numero que se ingresa
            int intNumeroMaximo = 0; // Numero maximo que se ingresa
            int intNumeroMinimo = 0; // Numero minimo que se ingresa
            double dblPromedio = 0; // Suma de los numeros
            int intContador = 0; // Contador para llenar el array
            bool boolBandera = true; // Bandera para controlar el While
            int[] arrayNumeros = new int[10]; // Array para guardar los numeros

            // Resolucion
            while (boolBandera) // Genero un bucle para pedir un numero nuevo
            {
                if (intContador != 10) // Mientras que el array no este completo, sigo pidiendo numeros
                {
                    if (intContador == 0) // Si es el primer numero ingresado
                    {
                        Console.Write("Ingrese un numero");
                        intNumero = int.Parse(Console.ReadLine()); // Se ingresa un numero
                        intNumeroMaximo = intNumero; // Se guarda el numero maximo
                        intNumeroMinimo = intNumero; // Se guarda el numero minimo
                        dblPromedio = intNumero; // Se suma el primer numero
                        arrayNumeros[intContador++] = intNumero; // Se agrega el numero ingresado en el array y incrementa el contador
                        Console.ReadKey(); // Pausa
                        Console.Clear(); // Limpieza
                    }
                    else // Si no es el primer numero ingresado
                    {
                        Console.Write("Ingrese un numero");
                        intNumero = int.Parse(Console.ReadLine()); // Se ingresa un numero
                        dblPromedio += intNumero; // Se suma el valor
                        arrayNumeros[intContador++] = intNumero; // Se agrega el numero ingresado en el array y incrementa el contador

                        if (intNumero > intNumeroMaximo) // Se verifica si el numero ingresado es el maximo
                        {
                            intNumeroMaximo = intNumero; // Se guarda el nuevo valor
                        }

                        if (intNumero < intNumeroMinimo) // Se verifica si el numero ingresado es el minimo
                        {
                            intNumeroMinimo = intNumero; // Se guarda el nuevo valor
                        }

                        Console.ReadKey(); // Pausa
                        Console.Clear(); // Limpieza
                    }
                }
                
                else // Si la condicion del contador no se cumple se cambia la bandera
                {
                    boolBandera = false; // Cambio de bandera
                }
            }

            Console.WriteLine($"El valor maximo es: {intNumeroMaximo}\nEl valor minimo es: {intNumeroMinimo}\nEl valor promedio es: {dblPromedio / 10}"); // Se imprime el mensaje solicitado
            Console.ReadKey(); // Pausa

        }
    }
}
