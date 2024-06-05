using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Simple
{
    public partial class Form1 : Form
    {
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }

        private void numbers()
        {
            
            Resultado.Text += $"{i}";
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
    }
}
