/*Faça um programa que leia dois números inteiros e mostre um menu com quatro
opções para o usuário escolher (soma, subtração, divisão, multiplicação). O algoritmo
deve imprimir o resultado da opção escolhida. Caso o usuário digite uma opção
inválida, mostrar mensagem de erro e encerrar o programa.*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int num1 = 0, num2 = 0, opcao = 0;
            Console.WriteLine("Informe 2 números inteiros");
            do
            {
                Console.Write("Informe o primeiro número: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Informe o segundo número: ");
                num2 = int.Parse(Console.ReadLine());
            } while (num1 <= 0 || num2 <= 0);
            do
            {
                Console.WriteLine("Digite o código correspondente a operaçõa que deseja realizar com os dois números");
                Console.WriteLine("1 - para somar ");
                Console.WriteLine("2 - para subtrair ");
                Console.WriteLine("3 - para multiplicar ");
                Console.WriteLine("4 - para dividir ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"{num1}+{num2}={num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"{num1}-{num2}={num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"{num1}x{num2}={num1 * num2}");
                        break;
                    case 4:
                        Console.WriteLine($"{num1}/{num2}={num1 / num2}");
                        break;
                    default:
                        Console.WriteLine("Erro, tente novamente");
                        opcao = 5;
                        break;
                }
            } while (opcao <= 0 || opcao > 5);
        }
    }
}