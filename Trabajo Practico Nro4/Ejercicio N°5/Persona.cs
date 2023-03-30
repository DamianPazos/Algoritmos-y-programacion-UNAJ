using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_5
{
    public class Persona
    {

        // Atributos

        private int edad;
        private string nombre;
        private int dni;
        private DateTime fechaNacimiento;

        // Constructor

        public Persona(string nombre,int dni, int edad)
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

        public string imprimir()
        {
            return ($"{nombre} ({edad}) {dni}");
        }

    }
}
