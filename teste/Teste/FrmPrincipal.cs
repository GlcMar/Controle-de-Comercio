using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chamada do formulario
            Form1 FrmUsuarioMdi = new Form1();
            //abrir o formulario usuario internamente
            FrmUsuarioMdi.MdiParent = this;
                FrmUsuarioMdi.Show();

        }

        private void usuarioPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarUsuario FrmUsuPerfil= new FrmListarUsuario();
            FrmUsuPerfil.MdiParent = this;
            FrmUsuPerfil.Show();
        }
    }
}
