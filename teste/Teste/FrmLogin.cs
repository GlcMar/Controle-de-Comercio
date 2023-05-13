using CONTROL;
using MODEL;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            Usuariocontroller usu = new Usuariocontroller();
            Usuario usuario= new Usuario();
            usuario.Login=txtLogin.Text;
            usuario.SenhaUsuario = txtSenha.Text;
            //acessar o sistema apos logar
            if (usu.Logar(usuario) == 1)
            {
                FrmPrincipal frmPrincipal= new FrmPrincipal();
                frmPrincipal.ShowDialog();

               // frmPrincipal.Dispose();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalida!");
            }
        }
    }
}
