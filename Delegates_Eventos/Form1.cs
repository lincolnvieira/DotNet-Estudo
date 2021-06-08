using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates_Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Associo ao evento click de cada botão, o metodo Calcular()
            btnSomar.Click += Calcular;
            btnSubtrair.Click += Calcular;
            btnMultiplicar.Click += Calcular;
            btnDividir.Click += Calcular;
        }

        //Defino o objeto da classe Calculadora
        static Calculadora calc = new Calculadora();

        //Defino os objetos delegates
        ExecutarCalculo Somar = new ExecutarCalculo(calc.Somar);
        ExecutarCalculo Subtrair = new ExecutarCalculo(calc.Subtrair);
        ExecutarCalculo Multiplicar = new ExecutarCalculo(calc.Multiplicar);
        ExecutarCalculo Dividir = new ExecutarCalculo(calc.Dividir);


        private void Calcular (object sender, EventArgs e)
        {
            decimal resultado = 0m;

            lblResultado.ResetText();
            lblResultado.ForeColor = Color.Black;

            try
            {
                decimal valor1 = txtValor1.Text.ValidarDecimal("O Valor 1 deve ser um número");
                decimal valor2 = txtValor2.Text.ValidarDecimal("O Valor 2 deve ser um número");

                switch (((Button)sender).Text)
                {
                    case "Somar":
                        resultado = Somar(valor1, valor2);
                        break;
                    case "Subtrair":
                        resultado = Subtrair(valor1, valor2);
                        break;
                    case "Multiplicar":
                        resultado = Multiplicar(valor1, valor2);
                        break;
                    case "Dividir":
                        resultado = Dividir(valor1, valor2);
                        break;
                    default:
                        break;
                }

                lblResultado.Text = resultado.ToString("C2");
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
                lblResultado.ForeColor = Color.Red;
            }
        }
    }
}
