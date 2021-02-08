using System;
using System.Globalization;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estrutura Condicional

            // 1 - Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não

            int x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine("Negativo");
            }
            else
            {
                Console.WriteLine("Não negativo");
            }

            // 2 - Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.

            x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("impar");
            }

            // 3 - Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            // Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
            // ordem crescente ou decrescente.

            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Multiplos");
            }
            else
            {
                Console.WriteLine("Não multiplos");
            }

            // 4 - Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
            // começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

            string[] arquivo = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(arquivo[0]);
            int horaFinal = int.Parse(arquivo[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O jogo durou " + duracao + " horas");

            // 5 - Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.A
            // seguir, calcule e mostre o valor da conta a pagar.

            string[] v1 = Console.ReadLine().Split(' ');
            int codigo = int.Parse(v1[0]);
            int quantidade = int.Parse(v1[1]);

            double total;
            if (codigo == 1)
            {
                total = quantidade * 4.0;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.5;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.0;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.0;
            }
            else
            {
                total = quantidade * 1.5;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            // 6 - Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
            //seguintes intervalos([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
            // nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (numero <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }

            // 7 - Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
            // de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
            // ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
            // Se o ponto estiver na origem, escreva a mensagem “Origem”.
            // Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
            // situação.

            string[] v2 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(v2[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(v2[1], CultureInfo.InvariantCulture);

            if (x1 == 0.0 && y1 == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x1 == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (x1 == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x1 > 0.0 && y1 > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x1 < 0.0 && y1 > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x1 < 0.0 && y1 < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}