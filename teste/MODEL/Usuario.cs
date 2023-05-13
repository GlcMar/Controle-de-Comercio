namespace MODEL
{
    public class Usuario
    {
       private int codUsuario;
       private string nome;
       private string email;
       private string fone;
        private int codigoPerfil;
        private string loginUsuario;
        private string senhaUsuario;
        private string fotoUsuario;
        public Usuario()
        {
            codUsuario = 0;
            nome = "";
            email = "";
            fone = "";
            loginUsuario = "";
            senhaUsuario = "";
            fotoUsuario = "";

        }
        //metodo para acessar pela view
        public int CodUsuario
        {
            //get obtem os dados da variavel
            get { return codUsuario; }
            //set altera as informações
            set { codUsuario = value; }
        }
        public string Login
        {
            get { return loginUsuario; }
            set { loginUsuario = value; }
        }
        public string SenhaUsuario
        {
            get { return senhaUsuario; }
            set { senhaUsuario = value; }
        }
        public string test(string valor)
        {
            return nome = valor;
        }
        public string GetNome()
        {
            return this.nome;
        }
        public string Getemail()
        {
            return this.email;
        }
        public string Getfone()
        {
            return this.fone;
        } public void setnome(string nome)
        {
            this.nome = nome;

        } public void setemail(string email)
        {
            this.email = email;
        }public void setfone (string fone)
        {
            this.fone = fone;
        }
        public string foto
        {
            get { return fotoUsuario; }
            set { fotoUsuario = value;}
        }
        public int Perfil
        {
            get { return codigoPerfil; }
            set { codigoPerfil = value; }
        }
    }
}