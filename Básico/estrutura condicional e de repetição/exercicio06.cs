/*Escreva um algoritmo que leia um número natural informado pelo usuário a partir
do teclado e que apresente como saída o fatorial desse número. Se o usuário
inserir um número negativo, o algoritmo deve informar que o número é inválido.*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, contador;
            Console.Write("Informe um número: ");
            num = int.Parse(Console.ReadLine());
            i = num;
            contador = num;
            if (num>0)
            {
                while (i > 1)
                {
                    i--;
                    contador *= i;
                    
                }
                Console.WriteLine($"O fatorial de {num}! é: {contador}");
            }
            else if (num == 0)
                Console.WriteLine($"O fatorial de 0! é: 1 ");
            else
                Console.WriteLine($"Você inseriu um número negativo, opção invalida tente novamente");
        }
    }
}