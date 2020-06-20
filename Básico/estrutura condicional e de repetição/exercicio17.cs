/*Faça um programa que receba três números obrigatoriamente em ordem crescente e um
quarto número que não siga essa regra. Mostre, em seguida, os quatro números em ordem
decrescente. Suponha que o usuário digitará quatro números diferentes.*/
using System;

public class Program
{
    public static void Main()
    {
        int num1, num2, num3, num4;
        Console.WriteLine("Programa para ordenar números");
        Console.WriteLine("Para começar, insira 3 números, mas o número que você digitar sempre deve ser maior que o anterior");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        if (num2 < num1)
        {
            Console.WriteLine($"Atenção! {num2} é menor que {num1},\nTente novamente: ");
            num2 = int.Parse(Console.ReadLine());
        }
        num3 = int.Parse(Console.ReadLine());
        if (num3 < num2)
        {
            Console.WriteLine($"Atenção! {num3} é menor que {num2},\ntente novamente: ");
            num3 = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Insira o número que quiser");
        num4 = int.Parse(Console.ReadLine());
        int[] lista = { num1, num2, num3, num4 };
        Array.Sort(lista);
        string[] palavra = { "Primeiro", "Segundo", "Terceiro", "Quarto" };
        for (int i = 0; i < lista.Length; i++)
        {
                Console.WriteLine($"O {palavra[i]} é: {lista[i]}");
        }
    }
}