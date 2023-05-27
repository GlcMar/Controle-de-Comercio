using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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

            //Depois de localizar os registros da primeira linha, ele irá adicionar
            // nas labels abaixo pra dar update depois.(Em comparação)

           
                 label1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                label2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                label3.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conexoes conexoes = new Conexoes();
            conexoes.AtualizarProduto(label1.Text, label2.Text, label3.Text, textBox8.Text, textBox9.Text, textBox10.Text);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
