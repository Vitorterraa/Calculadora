﻿using System;
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
    public partial class Jogo : Form
    {
        public Jogo()
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
    }
}
