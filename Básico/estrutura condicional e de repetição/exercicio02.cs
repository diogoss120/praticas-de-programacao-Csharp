/*Escreva um algoritmo que solicite como entrada um limite inferior natural e um
limite superior também natural. O algoritmo deve apresentar na tela todos os
números pares entre o limite inferior e superior. Os limites inferior e superior
devem ser apresentados se também forem números pares.
*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int mim, max, inicio;
            Console.Write("Informe o limite mínimo: ");
            mim = int.Parse(Console.ReadLine());
            Console.Write("Informe o limite máximo: ");
            max = int.Parse(Console.ReadLine());
            if (mim % 2 == 1)
                inicio = mim + 1;
            else
                inicio = mim;
            Console.Write($"Você digitou {mim} e {max}, os números pares entre eles são:");
            for (int i = inicio; i <= max; i += 2)
                Console.Write(i + " ");
        }
    }
}