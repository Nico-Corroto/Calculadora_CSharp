using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_2
{
    public partial class Form1 : Form
    {
        double x, y;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }
        Calculos.Suma objS;
        Calculos.Resta objR;
        Calculos.Multiplicacion objM;
        Calculos.Division objD;
        private void btnCero_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Calculadora
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Botón igual
            y = double.Parse(txtPantalla.Text);
            double sum;
            double res;
            double mul;
            double div;
            switch (operador)
            {
                case "+":
                    sum = objS.Sumar((x), (y));
                    txtPantalla.Text = sum.ToString();
                    break;
                case "-":
                    res = objR.Restar((x), (y));
                    txtPantalla.Text = res.ToString();
                    break;
                case "*":
                    mul = objM.Multiplicar((x), (y));
                    txtPantalla.Text = mul.ToString();
                    break;
                case "/":
                    div = objD.Dividir((x), (y));
                    txtPantalla.Text = div.ToString();
                    break;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }

        private void btnUnoMenos_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length == 1)
            {
                txtPantalla.Text = "";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length -1);
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            x = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            x = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            x = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnInversor_Click(object sender, EventArgs e)
        {
            operador = "+/-";
            x = double.Parse(txtPantalla.Text);
            x = x * (-1);
            txtPantalla.Clear();
        }

        private void btnCubo_Click(object sender, EventArgs e)
        {
            operador = "x ^ 3";
            x = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            operador = "/";
            x = double.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }
    }
}
