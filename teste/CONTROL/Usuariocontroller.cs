using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using MODEL;
using MySql.Data.MySqlClient;

namespace CONTROL
{
    public class Usuariocontroller
    {
        bool resultado = false;
        Conexao com = new Conexao();

        public bool cadastraUsuario(Usuario US)
        {
            try
            {
                string sql = "INSERT INTO usuario (nome,email,fone,foto,cod_perfil) values (@nome,@email,@fone,@foto,@perfil)";
                string[] campos = { "@nome", "@email", "@fone","@foto","@perfil" };
                string[] valores = { US.GetNome(), US.Getemail(), US.Getfone(),US.foto,US.Perfil.ToString() };
                if (com.cadastrar(campos, valores, sql) >= 1)
                {
                    return resultado = true;
                }
                else
                {
                    return resultado = false;
                }
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message);

            }

        }
        public bool atualizarUsuario(Usuario us)
        {
            try
            {
                string sql = "UPDATE SET USUARIO nome=@nome,email=@email, fone=@fone where cod_usuario=@codigo";
                string[] campos = { "@nome", "@email", "@fone" };
                string[] valores = { us.GetNome(), us.Getemail(), us.Getfone() };
                if (com.atualizardados(us.CodUsuario, campos, valores, sql) >= 1)
                {
                    return resultado = true;
                }
                else
                {
                    return resultado = false;
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        //crio o metodo apagar usuario 
        //retorna um valor boleano
        public bool apagarUsuario(Usuario us)
        {
            var resultado = false;
            try
            {
                //elabora minha query de delete
                string sql = "delete from usuario where cod_usuario=@codigo";
                //verifico se executou o metodo apagardados da conexão
                if(com.apagardados(us.CodUsuario,sql)==1)
                {
                    //se dados apagos retorna verdadeiro
                    resultado= true;
                }
                else
                {
                    //se dados não apagado retorna falso
                    resultado= false;
                }
               
            }catch(System.Exception ex)
            {
                //mostrar se houve algum erro no sistema ou banco
                throw new System.Exception(ex.Message);
            }
            
            return resultado;
        }
        //netodo para carregar as informações do usuario
        public Usuario CarregaUsuario(int codigo)
        {
            //chamo meu objeto usuario
            Usuario us= new Usuario();//chama a classe usuario
            try
            {
                com = new Conexao();//chama o metodo conexao
                MySqlConnection conn = com.getConexao();//obtenho a conexao do banco
                conn.Open();//abro o banco de dados
                MySqlCommand cmd= conn.CreateCommand();//executo o comando sql
                //passa a string sql
                cmd.CommandText = "SELECT * from usuario where cod_usuario=@codigo";
                //altero a variavel de consulta pelo codigo
                cmd.Parameters.AddWithValue("@codigo", codigo);
                //executo a consulta sql
                MySqlDataReader registro= cmd.ExecuteReader(); 
                if( registro.HasRows)// existe registro
                {
                    registro.Read();// leia a informação
                    //alterando a informação do email para o modelo usuario
                    us.setemail(registro["email"].ToString());
                    us.setfone(registro["fone"].ToString());
                    us.setnome(registro["nome"].ToString());
                    us.foto = registro["foto"].ToString();//recebe o caminho da foto


                }
                conn.Close();
            }catch(System.Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

            return us;
        }
       public int Logar(Usuario us)
    { 
          int registro = -1;//variavel de retorno
       //abro a conexao
        MySqlConnection conn= com.getConexao();
            //preparo a conexao
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select count(cod_usuario) from usuario where login=@login and senha=@senha";
            cmd.Parameters.AddWithValue("@login", us.Login) ;
            cmd.Parameters.AddWithValue("@senha", us.SenhaUsuario);
          //registro do sql convertendo o numero para inteiro
             registro=Convert.ToInt32(cmd.ExecuteScalar()); //executo minha query
            conn.Close();
            return registro;

         }
        public string getMD5Hash(string senha)
        {
            //cria o metodo de criptografia
            System.Security.Cryptography.MD5 md5=System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(senha);
            byte[] hash= md5.ComputeHash(inputBytes);
            StringBuilder sb=new StringBuilder();
            for(int i = 0; i <= hash.Length; i++)
            {
                //lendo caracter e convertendo o caracter pela string 
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();

        }
    }
    //metodo para entrar no sistema
    
}