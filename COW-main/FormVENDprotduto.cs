using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace COW
{
    public partial class FormVENDprotduto : Form
    {
        conexao con = new conexao();
        public FormVENDprotduto()
        {
            InitializeComponent();
        }

        private void FormVENDprotduto_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {









        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.getconexao();
            conexao.Open();
            string sqkcobsulta = "select * fron tb_estoque where "
            string sql = "INSERT INTO tb_item (nome_item,codigo) " + "VALUES " + "('" + NomeProduto.Text + "')";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataReader dr;
            dr = comando.ExecuteReader();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.getconexao();
            conexao.Open();
            string inserir1 = "insert into tb_item(nome) values " + "VALUES " + "('" + NomeProduto.Text, codigo, valor "')";
            MySqlCommand comando = new MySqlCommand(inserir1, conexao);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.getconexao();
            conexao.Open();
            string inserir1 = "delete from tb_item(nome) wherre tb_item;
            MySqlCommand comando = new MySqlCommand(inserir1, conexao);

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.getconexao();
            conexao.Open();
            string sql = "INSERT INTO tb_item (nome_item) " + "VALUES " + "('" + NomeProduto.Text + "')";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataReader dr;
            dr = comando.ExecuteReader();
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.getconexao();
            conexao.Open();
            string sql = "INSERT INTO tb_item (codigo) " + "VALUES " + "('" + codigo.Text + "')";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataReader dr;
            dr = comando.ExecuteReader();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexao con = new conexao();
            MySqlConnection conexao = con.getconexao();
            conexao.Open();
            string sql = "INSERT INTO tb_item (valor) " + "VALUES " + "('" + valor.Text + "')";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataReader dr;
            dr = comando.ExecuteReader();
        }
    }
}
