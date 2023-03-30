using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escriba un programa de aplicación que lea 2 palabras y determine si son palíndromos entre ellas. (Ej: “abbccd”
             * y “dccbba” son palíndromos).
             */

            // Variables

            string strPalabraUno; // Se declara la variable donde se guarda la primer palabra
            string strPalabraDos; // Se declara la variable donde se guarda la segunda palabra
            

            // Resolucion

            Console.Write("Ingrese la primer palabra:"); 
            strPalabraUno = Console.ReadLine(); // Se ingresa la primer palabra por teclado
            Console.Write("Ingrese la segunda palabra:");
            strPalabraDos = Console.ReadLine(); // Se ingresa la segunda palabra por teclado

            if (strPalabraUno.Length == strPalabraDos.Length) // Si tienen la misma cantidad de letras se analiza
            {
                int intCantidadLetras = strPalabraUno.Length; // Declaro e inicializo la cantidad de letras
                int intContadorLetras = 0; // Declaro e inicializo un contador de letras

                while (intCantidadLetras > 0) // Genero un bucle para repetir el if comparando las letras
                {
                    if (strPalabraUno[intContadorLetras] == strPalabraDos[intCantidadLetras - 1]) // Si coinciden las letras se pasa a verificar la proximas
                    {
                        if (intContadorLetras == strPalabraUno.Length - 1) // Si la cantidad de letras que quedan por verificar es cero, son palindromos
                        {
                            Console.WriteLine("Son palindromos"); // Mensaje de resultado
                        }

                        intContadorLetras++; // Incremento el contador
                        intCantidadLetras--; // Decremento la cantidad de letras que quedan por analizar
                    }
                    else // Si no coinciden las letras, no son palindromos
                    {
                        Console.WriteLine("No son palindromos"); // Mensaje de resultado
                        break;
                    }

                }
            }
            else // Si las palabras no tienen la misma longitud no son palindromos
            {
                Console.WriteLine("No son palindromos"); // Mensaje de resultado
            }
            Console.ReadKey();
        }
    }
}
