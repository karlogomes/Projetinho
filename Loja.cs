using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetinho
{
    class Loja


        32:28 15/09
    {
        public string nome;
        public string descricao;
        public string tecido;
        public string tamanho;
        public string marca;
        protected double preco;

        public void cadastrarPreco(double valor)
        {
            if (valor < 0)
            {
                preco = 0;
            }
            else
            {
                preco = valor;
            }                
        }
    }
}
