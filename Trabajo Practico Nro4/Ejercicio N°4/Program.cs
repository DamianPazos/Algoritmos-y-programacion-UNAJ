using System;
using System.Collections;
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
             * Escriba un programa de aplicación (Main) que permita al usuario ingresar en una consola una serie de 
             * datos de la forma "Nombre<TAB>Documento<TAB>Edad<ENTER>". El proceso de entrada finaliza con un 
             * string vacío.
             * Una vez finalizada la entrada de datos, el programa debe imprimir en la consola el listado con la forma:
             * Nro.) Nombre (Edad) <TAB> DNI. 
             * Ejemplo:
             * 1) Juan Perez (40) 2098745
             * 2) José García (41) 1965412
             * ...
             */

            // Variables

            bool boolBanderaMenu = true;
            string strDatosIngresados;
            ArrayList personaListado = new ArrayList();

            // Resolucion

            // Bucle para la repeticion de ingreso de valores
            while (boolBanderaMenu)
            {
                Console.WriteLine("Ingrese los datos como en el ejemplo:\nJuan Perez 2098745 40\nSiendo el nombre, el dni y por ultimo la edad\nPara salir ingrese solo el boton 'Enter'");
                strDatosIngresados = Console.ReadLine(); // Se ingresa el valor

                // Se verifica que no se haya ingresado un string vacio para salir del programa para guardar el objeto
                if (strDatosIngresados != "")
                {
                    Persona personaIngresada = new Persona(strDatosIngresados); // Se genera el objeto Persona
                    personaListado.Add(personaIngresada); // Se ingresa el objeto al arrayList
                    Console.WriteLine("Guardado con exito"); // Mensaje de guardado
                    Console.ReadKey(); // Pausa
                    Console.Clear(); // Limpieza de consola
                    
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
                string strImprimir = (i+1) + ") " + personaImprimir.imprimir(); // Se genera el mensaje
                Console.WriteLine(strImprimir); // Se imprime en consola
            }

            Console.ReadKey(); // Pausa
        }
    }
}
