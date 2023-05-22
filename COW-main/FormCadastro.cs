using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace COW
{
    public partial class FormCadastro : Form
    {
       
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin VoltaMeno = new FormLogin();
            VoltaMeno.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conexoes cadastrar = new Conexoes();
            cadastrar.Cadastrar(txt_nome.Text, txt_cpf.Text, txt_email.Text, txt_telefone.Text, txt_datanascimento.Text);            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_cpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_telefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_datanascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
