using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercícios 01

            // Fazer um programa para ler os dados de suas pessoas,
            // depois mostrar o nome da pessoa mais velha.

            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.idade = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.idade = double.Parse(Console.ReadLine());
            if (pessoa1.idade > pessoa2.idade)
            {
                Console.WriteLine($"{pessoa1.nome} é mais velha.");
            }
            else if (pessoa1.idade == pessoa2.idade)
            {
                Console.WriteLine($"Os dois são da mesma idade.");
            }
            else
            {
                Console.WriteLine($"{pessoa2.nome} é mais velha.");
            }

            // Exercícios 02

            // Fazer um programa para ler nome e salário de dois funcionários.
            // Depois, mostrar o salário médio dos funcionários.

            Funcionario funcionario = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario.nome = Console.ReadLine();
            Console.Write("Salario: ");
            funcionario.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nome: ");
            funcionario2.nome = Console.ReadLine();
            Console.Write("Salario: ");
            funcionario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = (funcionario.salario + funcionario2.salario) / 2.0;
            Console.WriteLine("Salário médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
