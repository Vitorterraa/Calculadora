namespace Calculadora
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
                Jogo formularioJogo = new Jogo();
                formularioJogo.ShowDialog();
                


            }
            else
            {
                progressBar1.Value = progressBar1.Value + 20;
            }









        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
