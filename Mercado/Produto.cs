using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    //No programa (Main) utiliza-se P como Produto desta classe.
    class Produto
    {
        public string Nome;
        public string Desc;
        public double Preco;
        public int Quantidade;

        public double CalcularPreco()
        {
            return Preco * Quantidade;
        }
        public int DiminuirQuantidade(int d)
        {
            return Quantidade -= d;
        }
        public int AumentarQuantidade(int a)
        {
            return Quantidade += a;
        }
        public override string ToString()
        {
            return "\n" + "Nome do produto: " + Nome + "\nDescrição: " + Desc + "\nPreço: " + Preco + "\nQuantidade: " + Quantidade + "\nValor total: " + CalcularPreco();
        }
    }
}
