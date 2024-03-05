using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class ClasePruebas
    {
        public int FuncionCalculadora(int num1, int num2, string operador)
        {
            int resultado = 0;

            if (operador == "-")
            {
                resultado = num1 - num2;
            }
            else if (operador == "+")
            {
                resultado = num1 + num2;
            }

            else if (operador == "*")
            {
                resultado = num1 * num2;

            }
            else if (operador == "/")
            {
                resultado = num1 / num2;
            }
            return resultado;
        }

        public int FuncionCapturaValor()
        {
            System.Console.WriteLine("Ingrese el primer numero: ");
            return int.Parse(System.Console.ReadLine());

        }


        public int FuncionCapturaValor2()
        {
            System.Console.WriteLine("Ingrese el segundo numero: ");
            return int.Parse(System.Console.ReadLine());

            
        }

    }
}
