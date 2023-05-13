using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COW
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            Thread.Sleep(0);
            this.Hide();


            FormLogin telaLogar = new FormLogin();

            telaLogar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Conexoes conexoes = new Conexoes();
            conexoes.Conectar();   // Isso é para testar a conexão assim que iniciar.



            //Conexao abrindo = new Conexao();
            //abrindo.Equals(this);



            /*
             * //Esse codigo abaixo é um texte e referência que verifica se se a conexao está OK e se ela é fechada sem problemas.
            try
            {
                var strconexao = "server = localhost; uid = admin; pwd = admin; database = abcde";

                var conexao = new MySqlConnection(strconexao);
                conexao.Open();
                MessageBox.Show("Funcionou");
                conexao.Close();


                MessageBox.Show("Conexao foi fechada.");
            } catch (Exception ex)
            {
                MessageBox.Show("Desculpe deu erro aqui: " + ex);
            
            
            }
            */


        }




    }
}
