using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COW
{
    public partial class FormDeletP : Form
    {
       
        public FormDeletP()
        {
            InitializeComponent();
        }

        private void FormDeletP_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProduto produto= new FormProduto();
            produto.ShowDialog();

        }



        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;

            Conexoes buscando = new Conexoes();
            string Search = "select nome_item, valor  , codigo  from tb_item where nome_item = @nome_item or valor = @valor or codigo = @codigo;";

            dataGridView1.DataSource = buscando.BuscaParaDeletar(Search, textBox1.Text, textBox1.Text, textBox1.Text);



            //dataGridView1.DataSource = buscando.BuscaEditarProduto(Search, textBox1.Text, textBox1.Text, textBox1.Text);

            //Conexoes buscando = new Conexoes();
            //string Search = "select nome_item, valor  , codigo  from tb_item where nome_item = @nome_item or valor = @valor or codigo = @codigo;";

            //dataGridView1.DataSource = buscando.BuscaEditarProduto(Search, textBox1.Text, textBox1.Text, textBox1.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Conexoes apagar = new Conexoes();
            apagar.DeletarProduto(label1.Text);




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
