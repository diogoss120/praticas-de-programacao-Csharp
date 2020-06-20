/*Faça um algoritmo que receba o custo de um espetáculo teatral e o preço do convite desse espetáculo.
Esse programa deve calcular e mostrar:
•a quantidade de convites que devem ser vendidos para que pelo menos o custo do espetáculo seja
alcançado.
•a quantidade de convites que devem ser vendidos para que se tenha um lucro de 30%.*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            informacoes();
        }
        static void informacoes()
        {
            int total = 0, convite = 0;
            Console.Write("Custo total para realizar o espetáculo: ");
            total = int.Parse(Console.ReadLine());
            Console.Write("Valor do convite: ");
            convite = int.Parse(Console.ReadLine());
            custo(total, convite);
        }
        static void custo(int custo, int conv)
        {
            double soma = custo / conv;
            Console.WriteLine($"Para não levar prejuiso, {soma} ingressos precisão ser vendidos");
            lucro(soma);
        }
        static void lucro(double calc)
        {
            calc *= 1.30;
            Console.WriteLine($"E para ter 30% de lucro {Math.Ceiling(calc)} ingressos precisam ser vendidos");
        }
    }
}