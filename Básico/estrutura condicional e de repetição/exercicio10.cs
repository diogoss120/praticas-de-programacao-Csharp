/*Faça um programa leia um valor N inteiro e positivo. Calcule e mostre o fatorial
de N*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, c, i;
            Console.WriteLine("Algoritmo para calcular o fatorial de um número");
            Console.Write("Informe o número que deseja calcular: ");
            num = int.Parse(Console.ReadLine());
            i = num;
            Console.Write($"O fatorial de !{num} é: ");
            for(c = num -1; c > 0;c--)
            {
                Console.Write($"{i} x ");
                num *=c;
                i--;
            }
           Console.Write($"1 = {num}");
        }
    }
}