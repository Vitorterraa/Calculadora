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
    public partial class frmCentimetro : Form
    {
        public frmCentimetro()
        {
            InitializeComponent();
        }



        private void btn0_Click(object sender, EventArgs e)
        {
            txtCent.Text = txtCent.Text + "1";
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            txtCent.Text = txtCent.Text + "2";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCent.Text = txtCent.Text + "3";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCent.Text = txtCent.Text + "4";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCent.Text = txtCent.Text + "5";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCent.Text = txtCent.Text + "6";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCent.Text = txtCent.Text + "0";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCent.Text = txtCent.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCent.Text = txtCent.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCent.Text = txtCent.Text + "9";
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            txtCent.Clear();
            txtPol.Clear();
        }

        private void btnvir_Click(object sender, EventArgs e)
        {
            txtCent.Text = txtCent.Text + ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double centimetro = Convert.ToDouble(txtCent.Text);
            double formula = centimetro / 2.54;
            txtPol.Text = formula.ToString();
        }
    }
}
