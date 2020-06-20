/*Faça um programa que apresente o menu de opções a seguir:
Menu de opções:
1. Média aritmética
2. Média ponderada
3. Sair*/
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            options();
        }
        static void options()
        {
            int num = 0;
            Console.WriteLine("Selecione a opção desejada");
            do
            {
                Console.WriteLine("1.Média aritmética\n2.Média ponderada\n3.Sair");
                num = int.Parse(Console.ReadLine());
            } while (num < 1 || num > 3);

            switch (num)
            {
                case 1:
                    medArit();
                    break;
                case 2:
                    medPon();
                    break;
                case 3:
                    Console.WriteLine("Você escolheu sair, volte outra vez");
                    break;
            }
            static void medArit()
            {
                Console.Write("Informe o primeiro número: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Informe o segundo número: ");
                int n2 = int.Parse(Console.ReadLine());
                double calc = (n1 + n2) / 2;
                Console.WriteLine($"Média aritmédica: {calc}");
            }
            static void medPon()
            {
                double n1, n2, n3, p1, p2, p3, soma;
                Console.Write("Informe a primeira nota: ");
                n1 = double.Parse(Console.ReadLine());
                Console.Write("Informe a segunda nota: ");
                n2 = double.Parse(Console.ReadLine());
                Console.Write("Informe a terceira nota: ");
                n3 = double.Parse(Console.ReadLine());
                Console.Write("Informe peso da primeira nota: ");
                p1 = double.Parse(Console.ReadLine());
                Console.Write("Informe peso da segunda nota: ");
                p2 = double.Parse(Console.ReadLine());
                Console.Write("Informe peso da terceira nota: " );
                p3 = double.Parse(Console.ReadLine());
                soma = (n1 * p1) + (n2 * p2) + (n3 * p3) / p1 + p2 + p3;
                Console.WriteLine($"A média poderada é {soma}");
            }
        }
    }
}


