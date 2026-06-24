using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {

        public Calculadora()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            txtHud2.Text = txtHud.Text;
            txtHud.Clear();
        }


        private void btnSub_Click(object sender, EventArgs e)
        {

        }

        private void btnVezes_Click(object sender, EventArgs e)
        {

        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void txtHud_TextChanged(object sender, EventArgs e)
        {
            //int i = 0;
            //if (txtHud.Text.Length > 1 && i <= 0)
            //{
            //    txtHud.Clear();
            //    i++;
            //}
            
            //transformar o texto em double, se tiver um zero na frente some
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtHud.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtHud.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtHud.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtHud.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtHud.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtHud.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtHud.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtHud.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtHud.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtHud.Text += "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHud.Clear();
        }
    }
}
