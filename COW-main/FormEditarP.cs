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
    }
}
