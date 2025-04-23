using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace refazendo.atividade
{
    public partial class Entregas : Form
    {
        public Entregas()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formProduto = new Produtos();
            formProduto.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formSecreto = new Secreto();
            formSecreto.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formclientes = new Clientes();
            formclientes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formpagar = new Pagar();
            formpagar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formentrega = new Entregas();
            formentrega.Show();
        }
    }
}
