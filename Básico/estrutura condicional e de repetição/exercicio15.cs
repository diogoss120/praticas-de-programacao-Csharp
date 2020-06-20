/*Faça um programa que leia um conjunto não determinado de valores e mostre o
valor lido, seu quadrado, seu cubo, e sua raiz quadrada. Finalize a entrada de dados com
um valor negativo ou zero.*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            double num = 1;
            
            while(num > 0)
            {
                Console.Write("\nInforme um número: ");
                num = double.Parse(Console.ReadLine());
                Console.WriteLine("Número digitado: "+num);
                Console.WriteLine("O quadrado dele: "+ Math.Pow(num, 2));
                Console.WriteLine("O cubo dele: "+Math.Pow(num, 3));
                Console.WriteLine("A raiz quadrada dele: "+Math.Sqrt(num));
            }

        }
    }
}
/*Faça um programa que leia um conjunto não determinado de valores e mostre o
valor lido, seu quadrado, seu cubo, e sua raiz quadrada. Finalize a entrada de dados com
um valor negativo ou zero.*/
