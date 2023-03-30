using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_2
{

    /*
     * Escriba un programa de aplicación que solicite al usuario ingresar su nombre y apellido, e imprima en la consola un 
     * saludo personalizado utilizando ese nombre e informe entre ( ) la cantidad de letras que conforman la oración 
     * impresa. Ejemplo: Hola Juan Perez, bienvenido a la materia ( 40 )
     */

    public class Program
    {
        static void Main(string[] args)
        {

            // Declaracion de variables
            string strNombre;
            string strApellido;
            string strMensaje;

            // Resolucion
            Console.Write("Ingrese el nombre: ");
            strNombre = Console.ReadLine(); // Ingreso el valor del nombre

            Console.Write("Ingrese el Apellido: ");
            strApellido = Console.ReadLine(); // Ingreso el valor del apellido

            strMensaje = $"Hola {strNombre} {strApellido}, bienvenido a la materia"; // Genero el mensaje

            // Resultado
            Console.WriteLine(strMensaje + $"({strMensaje.Length})"); // Devuelvo el mensaje por pantalla y le agrego la longitud del string
            Console.ReadKey(); // Genero una pausa para visualizar el resultado

        }
    }
}
