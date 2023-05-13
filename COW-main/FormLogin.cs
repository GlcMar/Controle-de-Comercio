using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COW
{
    public partial class FormLogin : Form
    {
      
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtCPFL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaL_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Conexoes logar = new Conexoes();
            logar.Logar(txtCPFL.Text, txtSenhaL.Text);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FormCadastro cadastrando = new FormCadastro();
            cadastrando.Show();


        }

        private void lblSenhaL_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
