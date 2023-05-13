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
    public partial class FormProduto : Form
    {

      


        public FormProduto()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVenda vend = new FormVenda();
            vend.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDevedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDevedores devedores= new FormDevedores();
            devedores.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNovProdu novoproduto = new FormNovProdu();
            novoproduto.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEditarP formEditarP = new FormEditarP();
            formEditarP.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDeletP deletP = new FormDeletP();
            deletP.Show();
        }
    }
}
