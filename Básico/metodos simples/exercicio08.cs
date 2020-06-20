/*Faça um algoritmo que leia o um número inteiro entre 1 e 7 e escreva o dia da semana correspondente.
Caso o usuário digite um número fora desse intervalo, deverá aparecer uma mensagem informando
que não existe dia da semana com esse número.*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            dias();
        }
        static void dias()
        {
            int dia = 0;
            Console.WriteLine("Escolha um número entre 1 e 7 para descobrir o dia da semana correspondente a ele");
            do
            {
                Console.Write("Digite um número: ");
                dia = int.Parse(Console.ReadLine());
                opcao(dia);
            } while (dia < 1 || dia > 7);
        }
        static void opcao(int numero)
        {
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda feira");
                    break;
                case 3:
                    Console.WriteLine("Terça feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta feira");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente");
                    break;
            }
        }
    }
}