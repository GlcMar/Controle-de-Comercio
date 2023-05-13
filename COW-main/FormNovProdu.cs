using MySql.Data.MySqlClient;
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
    public partial class FormNovProdu : Form
    {
        
        public FormNovProdu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexoes adicionarProduto = new Conexoes();
            adicionarProduto.NovoProduto(txt_nomeproduto.Text, txt_codigoproduto.Text, txt_valorproduto.Text);

            
            listView1.Items.Add(txt_nomeproduto.Text);
            listView3.Items.Add(txt_codigoproduto.Text);
            listView2.Items.Add(txt_valorproduto.Text);
            txt_nomeproduto.Text = string.Empty;
            txt_codigoproduto.Text = string.Empty;
            txt_valorproduto.Text = string.Empty;

            MessageBox.Show("Produto adicionado.");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormNovProdu_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
    }
}
