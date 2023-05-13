using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        string nome;
        string cpf;
        string email;
        string telefone;
        string data_nascimento;



        public Usuario()
        {
            nome = "";
            cpf = "";
            email = "";
            email = "";
            telefone = "";
            data_nascimento = "";
        }





        public string GetNome()
        {
            return this.nome;
        }

        public string Getcpf()
        {
            return this.cpf;
        }

        public string Getemail()
        {
            return this.email;
        }

        public string Gettelefone()
        {
            return this.telefone;
        }

        public string Getdata_nascimento()
        {
            return this.data_nascimento;
        }

        public string setnome()
        {
            return this.nome;
        }

        public void setcpf(string cpf)
        {
            this.cpf = cpf;
        }
        public void setemail(string email)
        {
            this.email = email;
        }

        public void settelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public void setdata_nascimento(string data_nascimento)
        {
            this.data_nascimento = data_nascimento;
        }




    }
}
