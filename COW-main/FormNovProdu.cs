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


            dataGridView2.Rows.Clear();

            string Coluna1 = txt_nomeproduto.Text;
            string Coluna2 = txt_codigoproduto.Text;
            string Coluna3 = txt_valorproduto.Text;


            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].HeaderText = "Nome do Produto";
            dataGridView2.Columns[1].HeaderText = "Codigo do Produto";
            dataGridView2.Columns[2].HeaderText = "Valor";
          
            string[] row = { Coluna1, Coluna2, Coluna3 };
            dataGridView2.Rows.Add(row);

            textBox6.Text = Coluna1;
            textBox5.Text = Coluna2;
            textBox1.Text = Coluna3;

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
            Conexoes CadastrarProduto = new Conexoes();
            CadastrarProduto.CadastroDeProdutos(textBox6.Text, textBox5.Text, textBox1.Text);
            


        }
    }
}
