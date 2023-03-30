using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_4
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             * Haga  un  programa de  aplicación que  lea  por  consola una  sucesión  de  palabras que  termina con  la 
             * palabra  vacía. Imprima el  porcentaje de palabras que comienzan con ‘s’, la longitud de cada palabra leída y 
             * el promedio de caracteres por palabra.
             * Ayuda: si st es una variable de tipo string, st.Length devuelve la cantidad de caracteres del string
             */

            // Variables

            string strPalabraIngresar; // Guarda la palabra ingresada
            double dblPorcentrajeLetraS; // Porcentaje de palabras que comienzan con 's'
            int intPalabrasLetraS = 0; // Cantidad de palabras que comienzan con 's', se inicializa con 0
            int intLongitudPalabra; // Cantidad de caracteres de la palabra introducida
            double dblPromedioCaracteres; // Promedio de caracteres
            int intCantidadPalabras = 0; // Cantidad de palabras ingresadas, se inicializa con 0
            bool boolBandera = true; // Bandera para salir del while
            int intSumaCaracteres = 0; // Suma total de todos los caracteres ingresados

            // Resolucion

            while (boolBandera) // Se ingresa al bucle de ingreso de palabras
            {
                Console.Write("Ingrese una palabra: ");
                strPalabraIngresar = Console.ReadLine(); // Se ingresa la palabra

                if( strPalabraIngresar == "") // Si el valor ingresado es "" se debe salir del while
                {
                    boolBandera = false; // Se cambia el valor de la bandera para que no continue el while
                }
                else
                {
                    intCantidadPalabras++; // Se incrementa la cantidad de palabras

                    if (strPalabraIngresar[0] == 's' || strPalabraIngresar[0] == 'S') // Si el nombre ingresado comienza con s, se adiciona el contador
                    {

                        intPalabrasLetraS++; // Se invrementa el contador de palabras que ingresan con s

                    }

                    intLongitudPalabra = strPalabraIngresar.Length; // Se toma el valor de longitud de la palabra
                    dblPorcentrajeLetraS = (intPalabrasLetraS * 100) / intCantidadPalabras; // Se calcula el porcentaje de palabras que comienzan con "s"
                    intSumaCaracteres += intLongitudPalabra; // Se realiza la suma para poder calcular el promedio
                    dblPromedioCaracteres = intSumaCaracteres / intCantidadPalabras; // Se calcula el promedio de longitud de palabras

                    Console.Write($"El porcentaje de palabras que comienza con 's' es {dblPorcentrajeLetraS}%\n");
                    Console.Write($"La longitud de la pabra ingresada es: {intLongitudPalabra} caracteres\n");
                    Console.Write($"El promedio de caracteres por palabra es: {dblPromedioCaracteres}\n");
                    Console.ReadKey(); // Pausa
                    Console.Clear(); // Limpia consola
                }

            }

        }
    }
}
