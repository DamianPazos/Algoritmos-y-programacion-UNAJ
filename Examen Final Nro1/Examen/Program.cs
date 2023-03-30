using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.Clases;

namespace Examen
{
    public class Program
    {
        static void Main(string[] args)
        {

            ArrayList listado = new ArrayList();
            Empleado emp1 = new Empleado(1,"Juan",25000,10);
            listado.Add(emp1);
            Empleado emp2 = new Empleado(2, "Ariel", 15000, 10);
            listado.Add(emp2);
            Empleado emp3 = new Empleado(3, "Damian", 55000, 10);
            listado.Add(emp3);
            Empleado emp4 = new Empleado(4, "Ana", 35000, 10);
            listado.Add(emp4);

            listaOrdenadaSueldo(listado);

            Console.ReadKey();


        }

        // Funciones
        public static void listaOrdenadaSueldo(ArrayList listaEmpleados)
        {
            int intCantidadEmpleados = listaEmpleados.Count;
            for (int i = 0; i < intCantidadEmpleados-1; i++)
            {
                Empleado empleadoI = (Empleado)listaEmpleados[i];
                for (int j = i+1; j < intCantidadEmpleados; j++)
                {
                    Empleado empleadoJ = (Empleado)listaEmpleados[j];
                    if( empleadoJ.Sueldo > empleadoI.Sueldo )
                    {
                        Empleado intercambio = empleadoJ;
                        listaEmpleados[j] = empleadoI;
                        listaEmpleados[i] = intercambio;
                    }
                }
            }

            for (int k = 0; k < intCantidadEmpleados; k++)
            {
                Empleado empleadoK = (Empleado)listaEmpleados[k];
                Console.WriteLine($"{empleadoK.Sueldo}");
            }

        }
    }
}
