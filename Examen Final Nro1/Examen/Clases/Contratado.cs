using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Clases
{
    internal class Contratado : Empleado
    {

        // Atributos
        private int duracionContrato;

        // Constructor
        public Contratado(int l, string n, double mon, int ht, int duracionContrato) : base(l, n, mon, ht)
        {
            this.duracionContrato = duracionContrato;
        }

        // Metodos
        public override void imprimirDatos()
        {
            Console.WriteLine($"Nombre y apellido: {nomyapellido}\nLegajo: {legajo}\nHoras trabajadas: {horasT}\nSueldo: {sueldo}\nDuracion de contrato: {duracionContrato}");
        }

    }
}
