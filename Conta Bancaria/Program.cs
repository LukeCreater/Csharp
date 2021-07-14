using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n): ");
            char depositoInicial = char.Parse(Console.ReadLine());
            if (depositoInicial == 's' || depositoInicial == 'S')
            {
                Console.Write("Digite o valor para depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(titular, numero, deposito);
                Console.WriteLine(c.ToString());
            }
            else if (depositoInicial == 'n' || depositoInicial == 'N')
            {
                c = new Conta(titular, numero);
                Console.WriteLine(c.ToString());
            }
            else
            {
                Console.WriteLine("Você não informou se terá depósito inicial ou não.");
            }

            Console.Clear();
        }
    }
}
