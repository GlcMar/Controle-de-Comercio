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
    public partial class FormDevedores : Form
    {
        public FormDevedores()
        {
            InitializeComponent();
        }

        private void FormDevedores_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVenda venda = new FormVenda();
            venda.ShowDialog();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProduto produto = new FormProduto();
            produto.ShowDialog();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCadastDevedor deved = new FormCadastDevedor();
            deved.ShowDialog();
        }
    }
}
