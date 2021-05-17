using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com os dados do produto:");
            Console.WriteLine("Nome do produto:");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço do produto:");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade do produto:");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dados do produto: {p}");

        }
    }
}
