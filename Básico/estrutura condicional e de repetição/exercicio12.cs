/*Faça um programa que receba o número, calcule e mostre a tabuada desse
número*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int num = 0;
            Console.WriteLine("Programa para fazer a tabuada de um número");
            Console.Write("Informe o número que deseja saber a tabuada: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine($"A tabuada de {num} é: ");
            for (int i = 0; i <=10 ; i++ )
            {
                Console.WriteLine($"{num}x{i}={num * i}");
            }
        }
    }
}