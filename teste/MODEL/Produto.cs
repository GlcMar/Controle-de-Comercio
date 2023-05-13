using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    //objeto produto
    public class Produto
    {//varivais
        private int cod_produto;
        private string nome_produto;
        private int quantidade;
        private float valor_produto;
        //contrutor do objeto produto
        public Produto() {
            cod_produto = 0;
            nome_produto = string.Empty;
            valor_produto = 0;
            quantidade = 0;
        }
        public int idProduto
        {
            get { return cod_produto; }
            set { cod_produto = value;}
        }
    }
}
