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



       




        public int DeletarProduto(string ItemADepetar)
        {
            int Registro = -1;
            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(ItemADepetar, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "delete from tb_item where nome_item = @nome_item;";
                cmd.Parameters.AddWithValue("@nome_item", ItemADepetar);
             
                Registro = cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Produto deletado.");
            }
            catch (Exception)
            {

                MessageBox.Show("Esse produto não existe.");


            }

            return Registro;
        }


       
        public int AtualizarProduto(string ItemA, string ItemB, string ItemC, string mudadoA, string mudadoB, string mudadoC)
        {
            int Registro = -1;
            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(ItemA, conn);
                cmd.CommandType = System.Data.CommandType.Text;

                // O objetivo aqui seria atualizar os dados que já estariam nas label abaixo da datagridview.
                //Atribuindo novos valores no lugar em q já foi adquirido do banco.
                cmd.CommandText = "UPDATE tb_item SET " + ItemA + " = " + mudadoA + " , " + ItemB + " = " + mudadoB + " , " + ItemC + " = " + mudadoC + " ; ";
                

                
                Registro = cmd.ExecuteNonQuery();
                conn.Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show("oxi" + ex);


            }

            return Registro;
        }





        public int CadastroDeDevedores(string nomeDevedor, string codigoDevedor, string NomeProdutoDevido, string ValorDoProduto)
        {
            int Registro = -1;



            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(nomeDevedor, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into tb_cliente(nome_cliente, cpf_cliente) values(@nome_cliente, @cpf_cliente);\r\ninsert into tb_item(nome_item, valor, codigo) values(@nome_item, @valor, @codigo);";
                cmd.Parameters.AddWithValue("@nome_cliente", nomeDevedor);
                cmd.Parameters.AddWithValue("@cpf_cliente", codigoDevedor);
                cmd.Parameters.AddWithValue("@nome_item", NomeProdutoDevido);
                cmd.Parameters.AddWithValue("@valor", ValorDoProduto);
                cmd.Parameters.AddWithValue("@codigo", codigoDevedor);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Devedor Cadastrado.");
            }
            catch (Exception)

            {
                MessageBox.Show("Alguma informação está incorreta. Tente novamente.");
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



        


        public DataTable BuscaParaDeletar(string Search, string result1, string result2, string result3)
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


                if(dados.Rows.Count > 0)
                {
                    MessageBox.Show("Produto encontrado.");
                }
                else
                {
                    MessageBox.Show("Nenhum item encontrado com esse nome.");
                };



                

            }
            catch
            {
                MessageBox.Show("Nada encontrado.");
            }


            return dados;
        }




        public DataTable ListarDividas(string CpfEndividado)
        {



            DataTable dados = new DataTable();

            try
            {
                conn = getConexao();
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(CpfEndividado, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select tb_item.nome_item, tb_item.valor from tb_item inner join\r\ntb_cliente where tb_cliente.cpf_cliente = tb_item.codigo;";
                cmd.Parameters.AddWithValue("@cpf_cliente", CpfEndividado);


                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dados);

                if (dados.Rows.Count > 0)
                {
                    
                }
                else
                {
                    MessageBox.Show("Nenhum item encontrado com esse nome.");
                };





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
