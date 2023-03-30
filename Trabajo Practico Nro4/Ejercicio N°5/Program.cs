using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Modifique el programa anterior agregando un campo privado FechaNacimiento. Defina un nuevo 
             * constructor que reciba como parámetro el nombre, la fecha de nacimiento (un DateTime) y el dni. Utilice 
             * ambos constructores para resolver el ejercicio, permitiendo ahora que el usuario tipee las entradas como: "Nombre<TAB>Documento<TAB>Edad<ENTER>"
             * o bien:
             * "Nombre<TAB>Documento<TAB>fecha de nacimiento<ENTER>"
             */

            // Variables

            bool boolBanderaMenu = true;
            string strDatosIngresados;
            ArrayList personaListado = new ArrayList();

            // Resolucion

            // Bucle para la repeticion de ingreso de valores
            while (boolBanderaMenu)
            {
                Console.WriteLine("Ingrese los datos como en el ejemplo:\nJuan Perez 2098745 40\nSiendo el nombre, el dni y por ultimo la edad o la fecha de nacimiento(dd/mm/yy)\nPara salir ingrese solo el boton 'Enter'");
                strDatosIngresados = Console.ReadLine(); // Se ingresa el valor

                // Se verifica que no se haya ingresado un string vacio para salir del programa para guardar el objeto
                if (strDatosIngresados != "")
                {
                    string[] arrayDatosIngresados = strDatosIngresados.Split(' ');
                    string strNombreIngresado = arrayDatosIngresados[0] + " " + arrayDatosIngresados[1];
                    int intDni = int.Parse(arrayDatosIngresados[2]);
                    if (arrayDatosIngresados[3].IndexOf('/') == -1)
                    {
                        int intEdad = int.Parse(arrayDatosIngresados[3]);
                        Persona personaIngresada = new Persona(strNombreIngresado,intDni,intEdad); // Se genera el objeto Persona
                        personaListado.Add(personaIngresada); // Se ingresa el objeto al arrayList
                        Console.WriteLine("Guardado con exito"); // Mensaje de guardado
                        Console.ReadKey(); // Pausa
                        Console.Clear(); // Limpieza de consola
                    }
                    else
                    {
                        DateTime dateFechaNacimiento = DateTime.Parse(arrayDatosIngresados[3]);
                        Persona personaIngresada = new Persona(strNombreIngresado, intDni, dateFechaNacimiento); // Se genera el objeto Persona
                        personaListado.Add(personaIngresada); // Se ingresa el objeto al arrayList
                        Console.WriteLine("Guardado con exito"); // Mensaje de guardado
                        Console.ReadKey(); // Pausa
                        Console.Clear(); // Limpieza de consola
                    }
                }

                // Si quiere salir del programa se cambia el estado de la bandera
                else
                {
                    boolBanderaMenu = false;
                    Console.Clear(); // Limpieza de consola
                }
            }

            // Se recorre el ArrayList para imprimir los datos guardados
            for (int i = 0; i < personaListado.Count; i++)
            {
                Persona personaImprimir = (Persona)personaListado[i]; // Se guarda el objeto
                string strImprimir = (i + 1) + ") " + personaImprimir.imprimir(); // Se genera el mensaje
                Console.WriteLine(strImprimir); // Se imprime en consola
            }

            Console.ReadKey(); // Pausa
        }
    }
}
