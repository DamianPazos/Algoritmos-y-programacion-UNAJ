using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Clases
{
    public class Oficina
    {

        // Atributos
        private ArrayList empleados;
        private string nombre;

        // Constructor
        public Oficina(string nombre)
        {
            empleados = new ArrayList();
            this.nombre = nombre;
        }

        // Metodos
        public void altaEmpleado(Empleado e)
        {
            empleados.Add(e);
        }

        /*public int empleadosPartTime()
        {

            int intCantidadEmpleadoPartTime = 0;
            int intCantidadEmpleadoTotal = empleados.Count;

            if (empleados.Count == 0)
            {
                return intCantidadEmpleadoPartTime;
            }
            else
            {
                if (empleados[intCantidadEmpleadoTotal - 1])
                {

                }
            }
        }*/

    }
}
