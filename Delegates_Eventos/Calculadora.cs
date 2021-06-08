using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Eventos
{
    //Definindo delegate
    public delegate decimal ExecutarCalculo(decimal n1, decimal n2);

    class Calculadora
    {

        public decimal Somar(decimal valor1, decimal valor2)
        {
            return valor1 + valor2;
        }

        public decimal Subtrair(decimal valor1, decimal valor2)
        {
            return valor1 - valor2;
        }
        public decimal Multiplicar(decimal valor1, decimal valor2)
        {
            return valor1 * valor2;
        }
        public decimal Dividir(decimal valor1, decimal valor2)
        {
            if (valor2 == 0)
                throw new Exception("Valor2 não pode ser zero");

            return valor1 - valor2;
        }

    }
}
