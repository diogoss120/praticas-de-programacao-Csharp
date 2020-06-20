/*Escreva um algoritmo que leia um valor para uma variável inteira n e que calcule a
tabuada de 1 até n.*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i;
            Console.Write("Calculadora\nInforme até qual número será feita a tabuada: ");
            num = int.Parse(Console.ReadLine());
            for(i = 0;i<=num; i++)
            {
                Console.WriteLine($"{i}x{num}={i * num}");
            }
        }
    }
}