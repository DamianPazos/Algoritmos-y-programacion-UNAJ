using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_3
{
    public class Persona
    {

        /*
         * Defina una clase Persona con 3 campos: Nombre, Edad y DNI. En el constructor utilice parámetros cuyos 
         * nombres coincidan con los campos privados del objeto (usar this). Agregue los métodos correspondientes 
         * a cada campo para poder consultar y modificar su contenido. 
         */

        // Atributos

        private string nombre;
        private int edad;
        private int dni;

        // Constructor

        public Persona(string nombre,int edad,int dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        // Get y set
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

    }
}
