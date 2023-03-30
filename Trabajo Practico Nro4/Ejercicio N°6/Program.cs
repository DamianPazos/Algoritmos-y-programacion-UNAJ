using System;
using System.Collections;
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
             *  Agregue a la clase Persona un método esMayorQue(Persona p) que devuelva verdadero si la persona que 
             *  recibe el mensaje es más grande que la persona recibida como parámetro. Utilícelo para realizar un 
             *  programa de aplicación (Main) que al recibir el arreglo de personas del ejercicio anterior retorne la 
             *  persona de mayor edad del grupo.
             */

            // Variables

            bool boolBanderaMenu = true;
            string strDatosIngresados;
            ArrayList arrayPersonaListado = new ArrayList();
            Persona personaMayor = null;

            // Resolucion

            // Bucle para la repeticion de ingreso de valores
            while (boolBanderaMenu)
            {
                Console.WriteLine("Ingrese los datos como en el ejemplo:\nJuan Perez 2098745 40\nSiendo el nombre, el dni y por ultimo la edad o la fecha de nacimiento(dd/mm/yy)\nPara salir ingrese solo el boton 'Enter'");
                strDatosIngresados = Console.ReadLine(); // Se ingresa el valor

                // Se verifica que no se haya ingresado un string vacio para salir del programa para guardar el objeto
                if (strDatosIngresados != "")
                {
                    string[] arrayDatosIngresados = strDatosIngresados.Split(' '); // Se separa el string por los espacios
                    string strNombreIngresado = arrayDatosIngresados[0] + " " + arrayDatosIngresados[1]; // Se guarda el nombre
                    int intDni = int.Parse(arrayDatosIngresados[2]); // Se guarda el dni

                    // Se verifica si el cuarto string tiene el caracter especial de fecha. IndexOf devuelve la posicion del caracter, pero si no lo encuentra devuelve -1. De esta forma podemos verificar si hay una fecha o una edad
                    if (arrayDatosIngresados[3].IndexOf('/') == -1)
                    {
                        int intEdad = int.Parse(arrayDatosIngresados[3]); // Se guarda la edad
                        Persona personaIngresada = new Persona(strNombreIngresado, intDni, intEdad); // Se genera el objeto Persona
                        arrayPersonaListado.Add(personaIngresada); // Se ingresa el objeto al arrayList
                        Console.WriteLine("Guardado con exito"); // Mensaje de guardado
                        Console.ReadKey(); // Pausa
                        Console.Clear(); // Limpieza de consola
                    }
                    else
                    {
                        DateTime dateFechaNacimiento = DateTime.Parse(arrayDatosIngresados[3]); // Se guarda la fecha
                        Persona personaIngresada = new Persona(strNombreIngresado, intDni, dateFechaNacimiento); // Se genera el objeto Persona
                        arrayPersonaListado.Add(personaIngresada); // Se ingresa el objeto al arrayList
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
            for (int i = 0; i < arrayPersonaListado.Count; i++)
            {
                Persona personaImprimir = (Persona)arrayPersonaListado[i]; // Se guarda el objeto
                string strImprimir = (i + 1) + ") " + personaImprimir.imprimir(); // Se genera el mensaje
                Console.WriteLine(strImprimir); // Se imprime en consola
            }

            Console.ReadKey(); // Pausa

            // Si hay al menos un valor en el ArrayList del listado de personas
            if (arrayPersonaListado.Count > 0)
            {
                personaMayor = (Persona)arrayPersonaListado[0]; // Se guarda el primer objeto (Persona)

                foreach (Persona personaComparar in arrayPersonaListado) // Se recorre y se compara uno a uno con la persona mayor en ese momento
                {
                    if (personaComparar.esMayorQue(personaMayor)) // Si cumple la condicion de ser mayor se guarda en persona mayor
                    {
                        personaMayor = personaComparar;
                    }
                }
                Console.WriteLine($"La persona mayor es: {personaMayor.Nombre}");
                Console.ReadKey();
            }
            
        }
    }
}
