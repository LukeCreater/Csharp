using System;

namespace Exercicio_Get_e_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.Write("Nome do Produto: ");
            p.Nome = Console.ReadLine();
            Console.Write("Quantidade do Produto: ");
            p.Quantidade = double.Parse(Console.ReadLine());
            Console.Write("Preço do Produto: ");
            p.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine(p.ToString());
            
        }
    }
}
