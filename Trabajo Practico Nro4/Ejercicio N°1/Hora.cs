using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_1
{
    public class Hora
    {

        // Atributos
        private int intHora;
        private int intMinutos;
        private int intSegundos;

        // Constructor
        public Hora(int hora, int minutos, int segundos)
        {
            intHora = hora;
            intMinutos = minutos;
            intSegundos = segundos;
        }

        public void imprimir()
        {
            Console.WriteLine($"{intHora} HORAS, {intMinutos} MINUTOS Y {intSegundos} SEGUNDOS"); // Mensaje a imprimir por el metodo
            Console.ReadKey(); // Pausa 
        }

    }
}
