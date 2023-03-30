using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_5
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             * Implemente un programa de aplicación que simule el funcionamiento de una calculadora que permita al usuario 
             * realizar  las  cuatro  operaciones  elementales  e  imprimir  el  resultado  de  la  operación.  Para  ello  
             * el  programa  debe mostrar un  menú  de opciones con cada  una  de  las  operaciones,  luego  de  seleccionar 
             * la  operación  el  programa pide ingresar dos números, realiza la operación solicitada e imprime el resultado.
             * Cada operación se resuelve con una función.El usuario debe poder realizar tantas operaciones como desee hasta 
             * seleccionar una opción de salida.  
             */

            // Variables

            double dblNumeroUno; // Primer numero a ingresar
            double dblNumeroDos; // Segundo numero a ingresar
            double dblResultado; // Resultado de la operaciones
            bool boolBanderaMenu = true; // Bandera para el While del menu
            string strOpcionMenu; // Opcion ingresada por teclado

            // Resolucion

            while (boolBanderaMenu) // Genero un while para la repeticion del menu y sus acciones hasta que asi lo deseen
            {
                Console.WriteLine("Ingrese la operacion que desea realizar:\n1.Suma\n2.Resta\n3.Multiplicacion\n4.Division\n5.Salir\n");
                strOpcionMenu = Console.ReadLine(); // Se ingresa el valor

                switch (strOpcionMenu) // Genero un switch para determinar que hacer en cada caso correspondiente
                {
                    case "1": // Caso de la opcion de suma
                        ingresarNumeros(); // Utilizo la funcion para ingresar numeros
                        dblResultado = sumar(dblNumeroUno, dblNumeroDos); // Aplico la funcion para sumar
                        devolverResultado(); // Aplico la funcion para devolver el resultado
                        break;
                    case "2": // Caso de la opcion de resta
                        ingresarNumeros(); // Utilizo la funcion para ingresar numeros
                        dblResultado = restar(dblNumeroUno, dblNumeroDos); // Aplico la funcion para restar
                        devolverResultado(); // Aplico la funcion para devolver el resultado
                        break;
                    case "3": // Caso de la opcion de multiplicacion
                        ingresarNumeros(); // Utilizo la funcion para ingresar numeros
                        dblResultado = multiplicar(dblNumeroUno, dblNumeroDos); // Aplico la funcion para multiplicar
                        devolverResultado(); // Aplico la funcion para devolver el resultado
                        break;
                    case "4": // Caso de la opcion de division
                        ingresarNumeros(); // Utilizo la funcion para ingresar numeros
                        if (dblNumeroDos == 0) // Valido que el numero divisor no sea 0, ya que no es posible dividir por el mismo
                        {
                            Console.WriteLine("No se puede dividir por 0"); // Mensaje de imposibilidad de calculo
                            Console.ReadKey(); // Pausa 
                            Console.Clear(); // Limpieza de consola
                            break;
                        }
                        else
                        {
                            dblResultado = dividir(dblNumeroUno, dblNumeroDos); // Aplico la funcion para dividir
                            devolverResultado(); // Aplico la funcion para devolver el resultado
                            break;
                        }
                    case "5": // Caso de salida del programa
                        boolBanderaMenu = false; // Se cambia la bandera para que no vuelva a ejecutar el while
                        break;

                    default: // Caso de ingreso de opcion invalida
                        Console.WriteLine("Se ingreso una opcion incorrecta"); // Mensaje de error
                        Console.ReadKey(); // Pausa
                        Console.Clear(); // Limpieza de consola
                        break;

                }

                


            }

            void ingresarNumeros() // Procedimiento para el ingreso de los valores
            {
                Console.Write("Ingrese el primer numero: ");
                dblNumeroUno = double.Parse(Console.ReadLine()); // Se ingresa el primer valor
                Console.Write("Ingrese el segundo numero: ");
                dblNumeroDos = double.Parse(Console.ReadLine()); // Se ingresa el segundo valor
            }

            void devolverResultado() // Procedimiento para la devolucion del resultado
            {
                Console.WriteLine($"El resultado es {dblResultado}"); // Imprime el resultado por pantalla
                Console.ReadKey(); // Genera una pausa para poder visualizar el resultado
                Console.Clear(); // Limpia la consola
            }
        }


        // Funciones

        public static double sumar(double num1, double num2) // Funcion para la suma
        {
            return num1 + num2;
        }

        public static double restar(double num1, double num2) // Funcion para la resta
        {
            return num1 - num2;
        }

        public static double multiplicar(double num1, double num2) // Funcion para la multiplicacion
        {
            return num1 * num2;
        }

        public static double dividir(double num1, double num2)
        {
            return (num1 / num2);
        }
        
    }
}
