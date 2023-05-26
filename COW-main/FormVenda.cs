using MySql.Data.MySqlClient;
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


namespace COW
{
    public partial class FormVenda : Form
    {

        public FormVenda()
        {
            InitializeComponent();
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            label2.Hide();

            Conexoes buscando = new Conexoes();

            dataGridView1.DataSource = buscando.TodosOsProdutos(label2.Text);

        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProduto produto= new FormProduto();
            produto.ShowDialog();
        }

        private void btnDevedor_Click(object sender, EventArgs e)
        {
            this.Hide();
           FormDevedores devedores = new FormDevedores();
            devedores.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVENDprotduto vendendo = new FormVENDprotduto();
            vendendo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNovPedido novoPedido = new FormNovPedido();
            novoPedido.ShowDialog();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            
           
        }

     
     


    }
}
