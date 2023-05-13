using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MODEL;
using CONTROL;
using MODEL;
using CONTROL;

namespace Teste
{
    public partial class Form1 : Form
    {
        //instancia o objeto usuário
        Usuario us = new Usuario();
        //instancia do controle do usuário
        int perfil;//codigo selecionado do perfil combobox
        Usuariocontroller usu = new Usuariocontroller();
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Cadastrar_Click(object sender, EventArgs e)
        {
       
            us.setnome(TXTnome.Text);
            us.setemail(TXTemail.Text);
            us.setfone(TXTfone.Text);
           us.foto=lblFoto.Text;
            us.Perfil= perfil;
            if (usu.cadastraUsuario(us) == true)
              //  label2.Text = us.test(TXTnome.Text);
            dtGridUsuario.Refresh();   // atualizar o grid apos inserir 
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            //atribuo o conteúdo do text codigo usuário para o modelo

           us.CodUsuario=Convert.ToInt32(TXTcod.Text);
           //se executar o metodo apagar corretamente retorna verdade
            if (usu.apagarUsuario(us) == true)
            {
                MessageBox.Show("Usuário excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Usuário não foi possivel a exclusão ");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexao com= new Conexao();
            //busca as informações  da conexao obter registro
            dtGridUsuario.DataSource= com.getRegistro("select cod_usuario,nome,email,fone,foto,login from usuario");
            //combobox com o perfil do usuário
            //conecto na conexao do banco no metodo getregistro
            cBoPerfil.DataSource = com.getRegistro("select * from perfil");
            cBoPerfil.DisplayMember = "nome";
            cBoPerfil.ValueMember = "cod_perfil";

        }

        private void dtGridUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //pega o ID do usuário
                int codigo= Convert.ToInt32(dtGridUsuario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                MessageBox.Show("Codigo selecionado:" + codigo);
                // carrega as informações na classe usuario
                us = usu.CarregaUsuario(codigo);
                //mostrar as informações no textbox
                TXTcod.Text = codigo.ToString();
                TXTemail.Text = us.Getemail();
                TXTfone.Text=us.Getfone();
                TXTnome.Text = us.GetNome();
                //busca a imagem do objeto
                picFoto.Image = Image.FromFile(us.foto);
            }catch(Exception ex)
            {
                MessageBox.Show("erro ao acessar o codigo: "+ex.Message);
            }
        }

        private void TXTcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char delete= (char)8;// codigo ascii do backspace
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar !=delete;

        }

        private void TXTcod_MouseLeave(object sender, EventArgs e)
        {

        }

        private void TXTcod_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(TXTcod, "Somente numero!");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //popular as informações na classe usuario
            us.setemail(TXTemail.Text);
            us.setfone(TXTfone.Text);
            us.setnome(TXTnome.Text);
            us.CodUsuario=Convert.ToInt32(TXTcod.Text);
           //chama o metodo atualizar do controle
            if(usu.atualizarUsuario(us)==true)
            {
                MessageBox.Show("Atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar as informações");
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            try
            {
                //abre a caixa de seleção da foto
                OpenFileDialog foto = new OpenFileDialog();
                foto.Filter = "Image Files(*.jpg;*.png)|*.jpg; *png";
                if(foto.ShowDialog() == DialogResult.OK )
                {//pega o nome do arquivo
                    lblFoto.Text = foto.FileName;
                    //captura o nome para o arquivo da foto
                    Image file=Image.FromFile( foto.FileName );
                    picFoto.Image = file;//carrega a foto selecionada
                }
                else
                {
                    MessageBox.Show("Não escolheu nenhuma imagem");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cBoPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            perfil = Convert.ToInt32(((DataRowView)cBoPerfil.SelectedItem)["cod_perfil"]);
        }

        private void dtGridUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
