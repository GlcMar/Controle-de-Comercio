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
            apagar.DeletarProduto(textBox1.Text);
           

        }
    }
}
