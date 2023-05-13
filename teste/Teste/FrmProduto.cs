using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;
using CONTROL;

namespace Teste
{
    public partial class FrmProduto : Form
    {
        Produto pd = new Produto();
        ProdutoController pdc = new ProdutoController();
        public FrmProduto()
        {
            InitializeComponent();
        }
    }
}
