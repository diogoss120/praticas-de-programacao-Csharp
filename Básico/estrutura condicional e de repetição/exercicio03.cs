/*Escreva um algoritmo que leia valores naturais a partir do teclado e que calcule a
média aritmética dos números informados que forem ímpares. O algoritmo deve
terminar a leitura dos números quando o usuário informar um número negativo.*/
using System;
public class Program
{
    public static void Main()
    {
        int num = 0;
        int i = 0;
        int[] lista = { };
        while (num >= 0)
        {
            Console.Write("Informe um número: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 1)
            {
                lista[i] += num;
                Console.WriteLine("Número armazenado no Array: " + lista[i] + "\n");
                i++;
            }
        }
    }
}