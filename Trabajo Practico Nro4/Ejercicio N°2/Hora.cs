using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_2
{
    public class Hora
    {

        // Atributos
        private int intHora;
        private int intMinutos;
        private int intSegundos;

        // Constructor Nro1
        public Hora(int hora, int minutos, int segundos)
        {
            intHora = hora;
            intMinutos = minutos;
            intSegundos = segundos;
        }

        // Constructor Nro2
        public Hora(string hora)
        {
            string strHora = hora;
            string[] arrayHora = hora.Split(':'); // Con el metodo Split se separa el string por un string especifico
            intHora = int.Parse(arrayHora[0]);
            intMinutos = int.Parse(arrayHora[1]);
            intSegundos = int.Parse(arrayHora[2]);
        }

        public void imprimir()
        {
            Console.WriteLine($"{intHora} HORAS, {intMinutos} MINUTOS Y {intSegundos} SEGUNDOS"); // Mensaje a imprimir por el metodo
            Console.ReadKey(); // Pausa 
        }

    }
}
