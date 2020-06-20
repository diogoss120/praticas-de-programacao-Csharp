/*Escreva um algoritmo que possua um método que receba por parâmetro um valor
natural N e que retorne o valor de S:
S = 1/1! + 1/2! + 1/3! + ... + 1 /N!
O algoritmo também deve possuir uma função fatorial para calcular os
denominadores dos termos da série.
*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Retorno();
        }
        static void Retorno()
        {
            int p;
            double valor = 0;
            do
            {
                Console.Write("Informe um limite: ");
                p = int.Parse(Console.ReadLine());
            } while (p <= 0);
            Console.Write("Valor de S: ");
            for (int i = 1; i <= p; i++)
            {
                valor += 1 / Fatorial(i);
            }
            Console.WriteLine(valor);
        }
        static double Fatorial(double num)
        {
            for(double i = num - 1; i > 0; i--)
            {
                num *= i;
            }
            return num;
        }
    }
}
