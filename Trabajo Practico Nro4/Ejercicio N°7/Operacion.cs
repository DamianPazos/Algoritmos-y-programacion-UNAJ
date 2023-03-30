using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N_7
{
    public class Operacion
    {

        // Atributos

        private double operando2;
        private double operando1;
        private string operador;

        // Constructor

        public Operacion(int operando1, int operando2, string operador)
        {

            this.operando1 = operando1;
            this.operando2 = operando2;
            this.operador = operador;

        }

        // Metodos

        // Metodo evaluar: Resuelve la operacion ingresada por el object Operacion
        public double evaluar()
        {

            double dblResultado;
            
            switch (operador)
            {
                case "+":
                    dblResultado = operando1 + operando2;
                    return dblResultado;

                case "-":
                    dblResultado = operando1 - operando2;
                    return dblResultado;

                case "*":
                    dblResultado = operando1 * operando2;
                    return dblResultado;

                case "/":
                    dblResultado = operando1 / operando2;
                    return dblResultado;
                default:
                    return 0;
            }
        }
    }
}
