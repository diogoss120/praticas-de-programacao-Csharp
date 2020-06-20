/*Escreva um algoritmo que leia vários números a partir do teclado e que apresente
na tela o maior e o menor número informado. O algoritmo também deve
apresentar a média aritmética de todos os números informados*/
using System;
public class Program
{
    public static void Main()
    {
        int num = 0, maior = 0, menor = 0, i = 0;
        double calculo, soma = 0;
        Console.WriteLine("Informe quantos números deseja informar? ");
        i = int.Parse(Console.ReadLine());
        for (int inicia = 0; inicia < i; )
        {
            Console.Write("Informe um número: ");
            num = int.Parse(Console.ReadLine());
            if (num > maior)
            {
                maior = num;
                if (menor == 0)
                    menor = num;
            }
            if (num < menor)
            {
                menor = num;
            }
            soma += num;
            inicia++;
        }
        calculo = soma / i;
        Console.Write($"O maior número é {maior} o menor é {menor}.\n" +
                       "A média aritmédica entre todos os números é: " + calculo);
    }
}
