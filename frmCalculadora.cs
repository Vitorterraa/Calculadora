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


    public partial class frmCalculadora : Form
    {
        float valor = 0;
        string operacao = "";

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            visor.Text = visor.Text + "0";
        }

        private void btncls_Click(object sender, EventArgs e)
        {
            visor.Clear();
        }

        private void btnadi_Click(object sender, EventArgs e)
        {
            valor = Convert.ToSingle(visor.Text);
            operacao = "adicao";
            visor.Text = "";


        }

        private void btnig_Click(object sender, EventArgs e)
        {
            if (this.operacao == "adicao")
            {
                float resultado = valor + Convert.ToSingle(visor.Text);
                visor.Text = resultado.ToString();
            }
            if (this.operacao == "subtracao")
            {
                float resultado = valor - Convert.ToSingle(visor.Text);
                visor.Text = resultado.ToString();
            }
            if (this.operacao == "multiplicacao")
            {
                float resultado = valor * Convert.ToSingle(visor.Text);
                visor.Text = resultado.ToString();
            }
            if (this.operacao == "divisao")
            {
                float resultado = valor / Convert.ToSingle(visor.Text);
                visor.Text = resultado.ToString();
            }

        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            valor = Convert.ToSingle(visor.Text);
            operacao = "subtracao";
            visor.Text = "";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            valor = Convert.ToSingle(visor.Text);
            operacao = "multiplicacao";
            visor.Text = "";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            valor = Convert.ToSingle(visor.Text);
            operacao = "divisao";
            visor.Text = "";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuConversao_Click(object sender, EventArgs e)
        {
            frmConversão formularioConversao = new frmConversão();
            formularioConversao.ShowDialog();
        }
    }
}
