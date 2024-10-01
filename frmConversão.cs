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
    public partial class frmConversão : Form
    {
        double celsius;
        double formula;

        public frmConversão()
        {
            InitializeComponent();
        }

        private void frmConversão_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = txtCelsius.Text + "0";
        }



        private void btn2_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = txtCelsius.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = txtCelsius.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = txtCelsius.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = txtCelsius.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = txtCelsius.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = txtCelsius.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = txtCelsius.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = txtCelsius.Text + "9";
        }



        private void btn1_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = txtCelsius.Text + "1";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            celsius = Convert.ToDouble(txtCelsius.Text);
            formula = celsius * 1.8 + 32;
            txtFah.Text = Convert.ToString(formula);

        }

        private void txtFah_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnvir_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = txtCelsius.Text + ",";
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            txtCelsius.Clear();
            txtFah.Clear();
        }

        private void frmConversão_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
