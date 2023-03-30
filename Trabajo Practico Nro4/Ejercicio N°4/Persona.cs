using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_4
{
    public class Persona
    {

        // Atributos

        private int edad;
        private string nombre;
        private int dni;

        // Constructor

        public Persona (string datos)
        {
            string strDatos = datos;
            string[] arrayDatos = datos.Split(' ');
            this.nombre = arrayDatos[0] + " " + arrayDatos[1];
            this.edad = int.Parse(arrayDatos[3]);
            this.dni = int.Parse(arrayDatos[2]);

        }

        // Metodos

        public string imprimir()
        {
            return ($"{nombre} ({edad}) {dni}");
        }

    }
}
