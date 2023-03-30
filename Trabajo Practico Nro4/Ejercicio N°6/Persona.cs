using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_6
{
    public class Persona
    {

        // Atributos

        private int edad;
        private string nombre;
        private int dni;
        private DateTime fechaNacimiento;

        // Constructor

        public Persona(string nombre, int dni, int edad)
        {

            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;

        }

        public Persona(string nombre, int dni, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
            DateTime dateFechaActual = DateTime.Now;
            edad = dateFechaActual.Year - fechaNacimiento.Year;
        }

        // Metodos

        // Devuelve el mensaje en consola
        public string imprimir()
        {
            return ($"{nombre} ({edad}) {dni}");
        }

        // Devuelve un true si la persona es mayor a la introducida en el parametro
        public bool esMayorQue(Persona personaParametro)
        {
            if (personaParametro.edad < edad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Get y set

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}
