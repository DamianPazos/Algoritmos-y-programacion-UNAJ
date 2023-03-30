using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Clases
{
    public class Empleado
    {

        // Atributos
        protected string nomyapellido;
        protected int legajo;
        protected int horasT;
        protected double sueldo;

        // Constructor
        public Empleado (int l,string n,double mon, int ht)
        {
            nomyapellido = n;
            legajo = l;
            horasT = ht;
            sueldo = mon;
        }

        // Get y set
        public int HorasT
        {
            get { return horasT; }
            set { horasT = value; }
        }

        // Metodos
        public virtual void imprimirDatos()
        {
            Console.WriteLine($"Nombre y apellido: {nomyapellido}\nLegajo: {legajo}\nHoras trabajadas: {horasT}\nSueldo: {sueldo}");
        }

    }
}
