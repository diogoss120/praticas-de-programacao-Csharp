/*Faça um algoritmo que leia um número maior ou igual a 10, deve-se validar a entrada, e informe
quantos divisores ele possui entre 1 e 9.*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            numero();
        }
        static void numero()
        {
            int num = 0;
            Console.WriteLine("Informe um número maior que 10");
            do
            {
                Console.Write("Digite um número: ");
                num = int.Parse(Console.ReadLine());
            } while (num < 10);
            operacao(num);
        }
        static void operacao(int numero)
        {
            int cont = 0;
            string text = "";
            for (int i = 1; i < 10; i++)
            {
                if (numero % i == 0)
                {
                    cont++;
                    text += i + " ";
                }
            }
            Console.WriteLine($"{numero} é divisivel por {cont} números, eles são: {text}");
        }
    }
}