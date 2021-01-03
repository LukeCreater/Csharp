using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace Mercado
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto P = new Produto();
            Console.WriteLine("Digite o nome do produto:");
            P.Nome = Console.ReadLine();
            Console.WriteLine("Digite a descrição do produto:");
            P.Desc = Console.ReadLine();
            Console.WriteLine("Digite o preço do produto:");
            P.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a quantidade do produto:");
            P.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Diminua a quantidade se quiser:");
            P.DiminuirQuantidade(int.Parse(Console.ReadLine()));
            Console.WriteLine("Aumente a quantidade se quiser:");
            P.AumentarQuantidade(int.Parse(Console.ReadLine()));

            P.CalcularPreco();

            Console.WriteLine(P.ToString());
            Console.ReadKey();
        }
    }
}