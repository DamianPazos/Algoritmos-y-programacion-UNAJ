using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_6
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             * Implemente una función que reciba una matriz (arreglo de dos dimensiones) pasada como parámetro, e imprima 
             * por consola la suma de sus elementos
             * static double sumaMatriz(double[,] matriz)
             * Ayuda: Si A es un arreglo, A.GetLength(i) devuelve la longitud del arreglo en la dimensión i.
             */

        }

        public static double sumaMatriz(double[,] arrayMatriz) // Genero la funcion solicitada
        {

            int intCantidadFilas = arrayMatriz.GetLength(0); // Guardo la cantidad de filas 
            int intCantidadColumnas = arrayMatriz.GetLength(1); // Guardo la cantidad de columnas
            double dblSumaMatriz = 0; // Se almacena la suma de los elementos de la matriz

            for (int intColumna = 0; intColumna < intCantidadColumnas; intColumna++) // Recorro cada columna
            {
                for (int intFila = 0; intFila < intCantidadFilas; intFila++) // Recorro cada fila
                {

                    dblSumaMatriz += arrayMatriz[intFila, intColumna]; // Se suma el elemento seleccionado

                }
            }

            return dblSumaMatriz; // Se retorna el valor de la suma de los elementos de la matriz
        }

    }
}
