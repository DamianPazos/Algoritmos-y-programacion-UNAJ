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
             * Defina una función que reciba una palabra y retorne en un vector la cantidad de cada una de las vocales que 
             * contiene. 
             */

        }

        public static int[] cantidadVocales(string strPalabra) // Se genera la funcion pedida
        {

            int[] arrayCantidadVocales = new int[5] {0,0,0,0,0}; // Arreglo de cantidad de vocales inicializado en 0
            int intCantidadLetras = strPalabra.Length; // Guardo la cantidad de letras que tiene la palabra ingresada

            for (int i = 0; i < intCantidadLetras; i++) // Recorro la palabra para verificar las vocales
            {

                switch (strPalabra[i]) // Dependiendo de la letra, verifico si es una vocal
                {
                    case 'a': // Caso en el cual la vocal es "a"
                        arrayCantidadVocales[0]++; // Adiciono el contador de la vocal
                        break;
                    case 'e': // Caso en el cual la vocal es "e"
                        arrayCantidadVocales[1]++; // Adiciono el contador de la vocal
                        break;
                    case 'i': // Caso en el cual la vocal es "i"
                        arrayCantidadVocales[2]++; // Adiciono el contador de la vocal
                        break;
                    case 'o': // Caso en el cual la vocal es "o"
                        arrayCantidadVocales[3]++; // Adiciono el contador de la vocal
                        break;
                    case 'u': // Caso en el cual la vocal es "u"
                        arrayCantidadVocales[4]++; // Adiciono el contador de la vocal
                        break;
                    default: // Caso en el cual no seria una vocal
                        break;

                }

            }
            
            return arrayCantidadVocales; // Devuelvo el arreglo con la cantidad de vocales
        }

    }
}
