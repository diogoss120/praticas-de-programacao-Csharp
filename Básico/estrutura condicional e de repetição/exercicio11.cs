/*Faça um programa que receba um número inteiro maior que 1, verifique se o
número fornecido é primo ou não e mostre uma mensagem de número primo ou de
número não primo. Um número é primo quando é divisível apenas por 1 e por ele
mesmo.*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int num = 2;
            Console.WriteLine("Programa para descobrir se um número é primo");
            //Console.Write("Informe o número: ");
            //num = int.Parse(Console.ReadLine());
            Repeticao(num);


        }
        static void Repeticao(int num)
        {
            int teste = 0;
            string pergunta = "sim";
            Console.Write("Informe o número: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    teste++;
            }
            if (teste == 2)
                Console.WriteLine($"{num} é um número primo");
            else
                Console.WriteLine($"{num} não é um número primo");

            Console.WriteLine("Deseja testar outro número? Digite Sim ou Nao ");
            pergunta = Console.ReadLine();
            pergunta = pergunta.ToLower();
            if (pergunta == "s" || pergunta == "si" || pergunta == "sim")
            {
                Repeticao(num);
            }
        }
    }
}