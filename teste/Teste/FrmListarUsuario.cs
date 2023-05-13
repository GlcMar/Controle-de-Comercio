using CONTROL;
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
    public partial class FrmListarUsuario : Form
    {
        TreeNode parentNode = null;//criar a arvore parente
        public FrmListarUsuario()
        {
            InitializeComponent();
        }

        private void FrmListarUsuario_Load(object sender, EventArgs e)
        {
            //chama a conexao
            Conexao com = new Conexao();
            //qual informação irei listar
            string SQL = "select * from perfil";
            //obtenho os dados
            DataTable UsPerfil = com.getRegistro(SQL);
            //listar os registros
            foreach (DataRow dr in UsPerfil.Rows)
            {
                parentNode = ListarUsuarioPerfil.Nodes.Add(dr["nome"].ToString());
                preencherTreeview(Convert.ToInt32(dr["cod_perfil"]), parentNode);
            }
            //abre a treeview se houver registro
            ListarUsuarioPerfil.ExpandAll();

        }
        // criando o metodo para preencher a arvore
        private void preencherTreeview(int parentId,TreeNode parentNode)
        {
            Conexao com = new Conexao();
            string strSQl = "select * from usuario inner join perfil on perfil.cod_perfil=usuario.cod_perfil where perfil.cod_perfil=" + parentId;
            //busca a consulta na conexao
            DataTable PerfilUsuario = com.getRegistro(strSQl);
            TreeNode childNode;
            //varre minha consulta
            foreach(DataRow dr in PerfilUsuario.Rows)
            {
                //se tiver vazio
                if (parentNode == null)
                {
                    childNode = ListarUsuarioPerfil.Nodes.Add(dr["nome"].ToString());

                }
                else
                {
                    childNode = parentNode.Nodes.Add(dr["nome"].ToString());
                }
            }
        }
    }
}
