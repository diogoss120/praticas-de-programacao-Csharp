/*Escreva um algoritmo que solicite um limite inteiro como entrada e que apresente
na tela os termos das séries abaixo menores ou iguais ao limite informado. O
algoritmo deve apresentar também a soma de todos os termos apresentados em
cada série.
*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Informe um limite: ");
            num = int.Parse(Console.ReadLine());

            Console.Write("De 3 em 3: ");
            for (int i = 0; i <= num; i += 3)
                Console.Write(i + " ");

            Console.Write("\nDe 5 em 5: ");
            for (int i = 0; i <= num; i += 5)
                Console.Write(i + " ");

            Console.Write("\nMultiplicado por 2: ");
            for (int i = 1; i <= num; i *= 2)
                Console.Write(i + " ");

            Console.Write("\nElevado ao cubo: ");
            for (int i = 1; i <= num; i++)
            {
                double calc = Math.Pow(i, 3);
                Console.Write(calc + " ");
            }
        }
    }
}