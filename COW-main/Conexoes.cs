using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace COW
{

    public class Conexoes
    {
      
        static private string servidor = "localhost";
        static private string db = "abcde";
        static private string usuario = "admin";
        static private string senha = "admin";
        public MySqlConnection conn = null;
        static public string StrCon = "server=" + servidor + ";database=" + db + ";user id=" + usuario + ";password=" + senha;

        public MySqlConnection getConexao()
        {
            conn = new MySqlConnection(StrCon);
            return conn;
        }

        public bool Conectar()
        {
            var result = false;
            try
            {
                getConexao().Open();
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                MessageBox.Show("Erro na conexão: \n" + ex);

            }
            return result;
        }

        public int Cadastrar(string nome, string cpf, string email, string telefone, string datadenascimento)
        {
            int Registro = -1;

            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(nome, conn); // nao entendi porque o codigo funcionou normalmente com essa linha
                cmd.CommandType = System.Data.CommandType.Text; // nao entendi pra que devo usar essa linha.
                cmd.CommandText = "insert into tb_cadastro(nome, datanascminto, telefone, cpf, email) values(@nome, @datanascminto, @telefone, @cpf, @email);";//passo o comando de apagar
                cmd.Parameters.AddWithValue("@nome", nome);//adiciona o codigo a string
                cmd.Parameters.AddWithValue("@datanascminto", datadenascimento);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@email", email);
                Registro = cmd.ExecuteNonQuery();//executa a query
                conn.Close();
                MessageBox.Show("Cadastrado com sucesso.");

                return Registro;
            }
            catch (Exception)
            {
                MessageBox.Show("Alguma informação está incorreta. Tente novamente");
                return Registro;
            }

        }

  
        public int Logar(string cpf, string telefone)
        {
            int Registro = -1;
            try
            {
                conn = getConexao();
                conn.Open();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand cmd = new MySqlCommand("select * from tb_cadastro where cpf = @cpf and telefone = @telefone;", conn);
                cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = cpf;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = telefone;
                adapter.SelectCommand = cmd;
                adapter.Fill(dataTable);

                //abaixo esta checando se o usuario existe ou nao.
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show("Logado");
                    FormVenda logado = new FormVenda();
                    logado.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha inválidos.");
                    FormLogin tenteNovalemnte = new FormLogin();
                    tenteNovalemnte.ShowDialog();

                }


            }
            catch (MySqlException puts)
            {
                MessageBox.Show("erro aqui: " + puts);

            }
            return Registro;
        }




        public int NovoProduto(string nome, string codigo, string valor)
        {
            int Registro = -1;
            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(nome, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into tb_item(nome_item, valor, codigo) values(@nome_item, @valor, @codigo);";
                cmd.Parameters.AddWithValue("@nome_item", nome);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                Registro = cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("oxi" + ex);


            }

            return Registro;
        }



       




        public int DeletarProduto(string CodigoDoProduto)
        {
            int Registro = -1;
            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(CodigoDoProduto, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "delete from tb_item where id_item = @id_item;";
                cmd.Parameters.AddWithValue("@id_item", CodigoDoProduto);
                Registro = cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Produto deletado.");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Esse produto não existe.");


            }

            return Registro;
        }



        //O problema nessa atualização abaixo, é que nao consegui obter os dados do banco para
        //importar pra dentro do datagrid, pra depois extrair pra label e atualizar.

        //Ele funciona perfeitamente. Mas nao está usando a datagrid, nem da pra ver o codigo la.
        //digite o id_item e mude  o nome da label1, 2 e 3 que funciona.
        public int AtualizarProduto(string idProduto, string NomeProduto, string codigoProduto, string ValorProduto)
        {
            int Registro = -1;
            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(idProduto, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE tb_item\r\nSET nome_item = @nome_item, valor = @valor, codigo = @codigo\r\nWHERE id_item = @id_item;";
                cmd.Parameters.AddWithValue("@id_item", idProduto);
                cmd.Parameters.AddWithValue("@valor", ValorProduto);
                cmd.Parameters.AddWithValue("@codigo", codigoProduto);
                cmd.Parameters.AddWithValue("@nome_item", NomeProduto);
                Registro = cmd.ExecuteNonQuery();
                conn.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show("oxi" + ex);


            }

            return Registro;
        }




        public int CadastroDevedor(string NomeCliente, string cpfCliente, string nomeproduto, string quantidade, string codigo)
        {
            int Registro = -1;



            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(NomeCliente, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO tb_cliente (nome_cliente, cpf_cliente)\r\n  VALUES(@nome_cliente,  @cpf_cliente);\r\nINSERT INTO tb_item (nome_item, valor, codigo) \r\n  VALUES(@nome_item, @valor, @codigo);";
                cmd.Parameters.AddWithValue("@nome_cliente", NomeCliente);
                cmd.Parameters.AddWithValue("@cpf_cliente", cpfCliente);
                cmd.Parameters.AddWithValue("@nome_item", nomeproduto);
                cmd.Parameters.AddWithValue("@valor", quantidade);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Devedor cadastrado.");
            }
            catch (Exception ex)

            {
                MessageBox.Show("Alguma informação está incorreta." + ex);
            }


            return Registro;
        }




        public DataTable BuscaEditarProduto(string Search, string result1, string result2, string result3)
        {



            DataTable dados = new DataTable();

            try
            {
                conn = getConexao();
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(Search, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = Search;
                cmd.Parameters.AddWithValue("@nome_item", result1);
                cmd.Parameters.AddWithValue("@valor", result2);
                cmd.Parameters.AddWithValue("@codigo", result3);


                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dados);

                MessageBox.Show("Funcionou.");



            }
            catch
            {
                MessageBox.Show("Nada encontrado.");
            }


            return dados;
        }






        public int CadastroDeProdutos(string NomeProduto, string CodigoDoProduto, string valorDoProduto)
        {
            int Registro = -1;



            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(NomeProduto, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into tb_item(nome_item, valor, codigo) values (@nome_item, @valor, @codigo);";
                cmd.Parameters.AddWithValue("@nome_item", NomeProduto);
                cmd.Parameters.AddWithValue("@valor", CodigoDoProduto);
                cmd.Parameters.AddWithValue("@codigo", valorDoProduto);
           
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Produto Cadastrado.");
            }
            catch (Exception ex)

            {
                MessageBox.Show("Alguma informação está incorreta." + ex);
            }

            return Registro;
        }

        internal void NovoPedido(string text1, string text2)
        {
            throw new NotImplementedException();
        }
    }
}
