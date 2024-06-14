using System;
using System.Data;
using System.Windows.Forms;

namespace Calculadora_Simple
{
    public partial class Form1 : Form
    {
        float i = 0;              //este float lo utilizo como base en cada botón que indica un número.
        string operation = null;  //este string sirve para detectar simbolos como el +,-,= etc.
        float result = 0;
        float secondary = 0;

        bool complexOperation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Resultado_Click(object sender, EventArgs e) { }

        private void last_Click(object sender, EventArgs e) { }

        private void numbers()
        {
            Resultado.Text += $"{i}";
        }

        private void operations()
        {
                try
                {
                    result = float.Parse(Resultado.Text);  
                    Resultado.Text = $"";
                    last.Text = $"{result} {operation}";
                }
                catch { }
        }

        private void equal_Click(object sender, EventArgs e)
        {

            try
            {
                secondary = float.Parse(Resultado.Text);  // Cambiado a float.Parse
                if (operation == "+")
                    Resultado.Text = $"{result + secondary}";

                else if (operation == "-")
                    Resultado.Text = $"{result - secondary}";

                else if (operation == "*")
                    Resultado.Text = $"{result * secondary}";

                else if (operation == "/")
                    Resultado.Text = $"{result / secondary}";

            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
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
            last.Text = "";
            result = 0;
            secondary = 0;
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (!Resultado.Text.Contains(","))
            {
                Resultado.Text += ",";
            }
        }

        private void multiplicado_Click(object sender, EventArgs e)
        {
            operation = "*";
            complexOperation = true;
            operations();
        }

        private void dividido_Click(object sender, EventArgs e)
        {
            operation = "/";
            complexOperation = true;
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
            complexOperation = false;
            operations();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operation = "-";
            complexOperation = false;
            operations();
        }

        
    }
}