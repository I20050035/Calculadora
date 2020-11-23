using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTestMetodoEvento
{
    public partial class Form1 : Form
    {
        double valor1, valor2;
        string operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Mimetodo_Click(object sender, EventArgs e)
        {
            string textoBoton = ((Button)sender).Text.Trim();
            switch (textoBoton)
            {
                case "R":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                     
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado = Math.Sqrt(valor1);
                    lblNumeros.Text = resultado + "";
                    break;

                case "Log":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }

                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado1 = Math.Log(valor1);
                    lblNumeros.Text = resultado1 + "";
                    break;

                case "Cos":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }

                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado2 = Math.Cos(valor1);
                    lblNumeros.Text = resultado2 + "";
                    break;

                case "Sin":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }

                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado3 = Math.Sin(valor1);
                    lblNumeros.Text = resultado3 + "";
                    break;

                case "Abs":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }

                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado4 = Math.Abs(valor1);
                    lblNumeros.Text = resultado4 + "";
                    break;


                case "Tan":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }

                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado5 = Math.Tan(valor1);
                    lblNumeros.Text = resultado5 + "";
                    break;

                case "Exp":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }

                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado6 = Math.Exp(valor1);
                    lblNumeros.Text = resultado6 + "";
                    break;

                case "Acos":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }

                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado7 = Math.Acos(valor1);
                    lblNumeros.Text = resultado7 + "";
                    break;

                case "Asin":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }

                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado8 = Math.Asin(valor1);
                    lblNumeros.Text = resultado8 + "";
                    break;

                case "Atan":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }

                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado9 = Math.Atan(valor1);
                    lblNumeros.Text = resultado9 + "";
                    break;

                case "Cosh":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }

                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado10 = Math.Cosh(valor1);
                    lblNumeros.Text = resultado10 + "";
                    break;

                case "Log10":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }

                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado11 = Math.Log10(valor1);
                    lblNumeros.Text = resultado11 + "";
                    break;

                case "+":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;

                case "-":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "X":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;
                case "/":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;


                case "=":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    switch (operacion)
                    {
                        case "+":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 + valor2) + "";
                            break;
                        case "-":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 - valor2) + "";
                            break;
                        case "X":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 * valor2) + "";
                            break;
                        case "/":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 / valor2) + "";
                            break;
                    }
                    break;
                case "AC":
                    lblNumeros.Text = "";
                    break;
                case ".":
                    if (lblNumeros.Text.IndexOf(".") == -1)
                    {
                        lblNumeros.Text += textoBoton;
                    }
                    break;
                default:
                    lblNumeros.Text += textoBoton;
                    break;
            }
        }


    }
}