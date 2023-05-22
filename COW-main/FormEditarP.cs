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
    public partial class FormEditarP : Form
    {
        
        public FormEditarP()
        {
            InitializeComponent();
        }

        private void FormEditarP_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProduto produto = new FormProduto();
            produto.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProduto produto = new FormProduto();
            produto.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conexoes buscando = new Conexoes();
            string Search = "select nome_item, valor  , codigo  from tb_item where nome_item = @nome_item or valor = @valor or codigo = @codigo;";

            dataGridView1.DataSource = buscando.BuscaEditarProduto(Search, textBox1.Text, textBox1.Text, textBox1.Text);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexoes atualizacao = new Conexoes();
            atualizacao.AtualizarProduto(textBox1.Text, label1.Text, label2.Text, label3.Text);
        }
    }
}
