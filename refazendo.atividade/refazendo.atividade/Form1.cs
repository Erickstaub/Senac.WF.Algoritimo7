namespace refazendo.atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0000")
                MessageBox.Show("Seus dados foram vazad... digo, seus dados foram salvo, é nois cumpincha");
            else
                MessageBox.Show("Senha errada");

        }




        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Acessece " + "https://shopee.com.br/buyer/reset");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Iniciando Mineradora de Bitcoin...");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("bye bye baby ", "Sair",
                MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
                Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "USUARIO")
                textBox1.Text = string.Empty;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
                textBox1.Text = "USUARIO";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "SENHA")
                textBox2.Text = string.Empty;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
                textBox2.Text = "SENHA";

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("A senha é 0000");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vai cutucar tua mâe");
        }
    }
}
