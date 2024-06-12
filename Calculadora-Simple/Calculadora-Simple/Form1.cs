using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simple
{
    public partial class Form1 : Form
    {
        float i = 0;              //este int lo utilizo como base en cada botón que indica un número.
        string operation = null;  //este string sirve para detectar simbolos como el +,-,= etc.
        float result = 0;
        float secondary = 0;

        bool complexOperation = false;

        public Form1()
        {
            InitializeComponent();
            if (operation != "+")
                complexOperation = true;
            else if (operation != "-")
                complexOperation = true;

            else 
                complexOperation = true;
            
        }

        private void Resultado_Click(object sender, EventArgs e) { }
        
        private void numbers()
        {
            Resultado.Text += $"{i}";
        }

        private void operations()
        {
            if (!complexOperation)
            {
                try
                {
                    result = int.Parse(Resultado.Text);
                    Resultado.Text = $"{operation}";
                }
                catch { }
            }
            else
            {
                try
                {
                    result = int.Parse(Resultado.Text);
                    Resultado.Text = "";
                }
                catch { }
            }
        }

        private void equal_Click(object sender, EventArgs e)
                    //operation = "=";
        {
            if (complexOperation == false)
            {
                try
                {
                    secondary = int.Parse(Resultado.Text);
                    Resultado.Text = $"{result + secondary}";
                }
                catch { }
            }
            else
            {
                try
                {
                    secondary = int.Parse(Resultado.Text);
                    DataTable dt = new DataTable();
                    double answer = (double)dt.Compute($"{result}{operation}{secondary}", "");

                    Resultado.Text = $"{answer}";
                }
                catch { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
                    //Delete button
        {
            try
            {
                Resultado.Text = Resultado.Text.Remove(Resultado.Text.Length - 1, 1);
            }
            catch { }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            Resultado.Text = "";
            result = 0;
            secondary = 0;
        }

        private void multiplicado_Click(object sender, EventArgs e)
        {
            operation = "*";
            operations();
        }

        private void dividido_Click(object sender, EventArgs e)
        {
            operation = "/";
            operations();
        }

        private void number0_Click(object sender, EventArgs e)
        {
            i = 0;
            numbers();
        }

        private void number1_Click(object sender, EventArgs e)
        {
            i = 1;
            numbers();
        }

        private void number2_Click(object sender, EventArgs e)
        {
            i = 2;
            numbers();
        }

        private void number3_Click(object sender, EventArgs e)
        {
            i = 3;
            numbers();
        }

        private void number4_Click(object sender, EventArgs e)
        {
            i = 4;
            numbers();
        }

        private void number5_Click(object sender, EventArgs e)
        {
            i = 5;
            numbers();
        }

        private void number6_Click(object sender, EventArgs e)
        {
            i = 6;
            numbers();
        }

        private void number7_Click(object sender, EventArgs e)
        {
            i = 7;
            numbers();
        }

        private void number8_Click(object sender, EventArgs e)
        {
            i = 8;
            numbers();
        }

        private void number9_Click(object sender, EventArgs e)
        {
            i = 9;
            numbers();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operation = "+";
            operations();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operation = "-";
            operations();
        }

        
    }
}
