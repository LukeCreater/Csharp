using System.Globalization;

namespace Exercicio_Get_e_Set
{
    class Produto
    {
        private string nome;
        private double quantidade;
        private double preco;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public override string ToString()
        {
            return "Nome do Produto: " + nome + ", Quantidade: " + quantidade + ", Preço: " + preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}