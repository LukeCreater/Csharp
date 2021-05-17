using System;
using System.Globalization;

namespace curso
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque ()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return $"{Nome}, ${Preco}, {Quantidade} restantes e {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)} valor acumulado."; 
        }
    }
}
