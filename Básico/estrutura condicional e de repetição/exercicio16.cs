/*Faça um programa que leia um número não determinado de pares de valores [m,
n], todos inteiros positivos, um par de cada vez, e que calcule e mostre a soma de todos
os números inteiros entre m e n (inclusive). A digitação de pares terminará quando m
for maior ou igual a n*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int m = 0, n = 1;
            Console.WriteLine("Informe dois números inteiros: ");
            while (m < n)
            {
                Console.Write("Informe M: ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Informe N: ");
                n = int.Parse(Console.ReadLine());
                loop(m, n);
            }
        }
        static void loop(int num1, int num2)
        {
            int maior, menor, soma = 0;
            if (num1 > num2)
            {
                maior = num1;
                menor = num2;
            }
            else
            {
                maior = num2;
                menor = num1;
            }
            for (int i = menor; i <= maior; i++)
            {
                soma += i;
            }
            Console.WriteLine($"A soma dos números entre {menor} e {maior} é: {soma}\n");
        }
    }
}
/*Faça um programa que leia um número não determinado de pares de valores [m,
n], todos inteiros positivos, um par de cada vez, e que calcule e mostre a soma de todos
os números inteiros entre m e n (inclusive). A digitação de pares terminará quando m
for maior ou igual a n.*/
