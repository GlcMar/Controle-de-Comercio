using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using MySql.Data.MySqlClient;

namespace CONTROL
{
    public class Conexao
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
            }
            return result;
        }
        public int cadastrar(string[] campos, string[] valores, string SQLinsert)
        {
            int registro = -1;
            try
            {
                conn= getConexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SQLinsert, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = SQLinsert;
                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }
                registro = cmd.ExecuteNonQuery();
                conn.Close();
                return registro;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
        }
        //metodo para excluir a informação
        public int apagardados(int codigo,string SQL)
        {
            //declaro a varivel
            int registroAfetado=-1;
            try
            {
                //metodo para chamar a conexão
                conn= getConexao();
                conn.Open(); //abro a conexao
                //preparo a instrução sql
                MySqlCommand cmd= new MySqlCommand(SQL, conn);
                //preparo para receber a string
                cmd.CommandType= System.Data.CommandType.Text;
               //monto a instrução sql
                cmd.CommandText = SQL;
                //substituo o parametro pelo conteuso
                cmd.Parameters.AddWithValue("@codigo", codigo);
               //executo minha query
                registroAfetado= cmd.ExecuteNonQuery();
                conn.Close();//fecho banco de dados
                return registroAfetado; //retorno o resultado
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public int atualizardados(int codigo,string[] campos, string[] valores,string SQL) {
            int registroAfetado=-1;
            try
            {
                conn = getConexao();
                conn.Open();
                MySqlCommand cmd=new MySqlCommand (SQL, conn);
                cmd.CommandType= System.Data.CommandType.Text;
                cmd.CommandText = SQL;
                for(int i=0;i<valores.Length;i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);

                }
                cmd.Parameters.AddWithValue("@codigo", codigo);
                registroAfetado= cmd.ExecuteNonQuery();
                conn.Close();
                return registroAfetado;
            }catch(Exception ex) { throw ex; }
        }
        //metdo para buscar registros
        public DataTable getRegistro(string sql)
        {
            DataTable registro = new DataTable();
             try
            {//obter conexao
                conn= getConexao();
                //abrir conexao
                conn.Open();
                //preparo o comando sql
                MySqlCommand cmd = new MySqlCommand(sql, conn);
               //preparo para receber a string sql
                cmd.CommandType=System.Data.CommandType.Text;
                cmd.CommandText = sql; //abribuo o script
                //preparo a leitura da informação
                MySqlDataAdapter dados = new MySqlDataAdapter(cmd);
                dados.Fill(registro);//filtra as informações
                conn.Close(); //fecha a conexao
                return registro; //retorna as informações
              
            }catch(Exception ex)
            {
                throw ex;
            }
        
        }
    }
}
