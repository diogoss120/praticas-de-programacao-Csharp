/*A série de Fibonacci começa com os termos 0 e 1 e tem a propriedade de que cada
temo subsequente equivale à soma dos dois termos anteriores. Escreva um
algoritmo que leia um limite a partir do teclado e que apresente na tela os termos
da série de Fibonacci menores ou iguais ao limite informado. O algoritmo também
deve apresentar a soma dos termos gerados*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i = 2, a = 0, b = 1;
            Console.WriteLine("Programa para calcular a série de Fibonacci");
            Console.Write("Para isso, informe um limite para o calculo: ");
            num = int.Parse(Console.ReadLine());
            int[] lista = new int[num];
            lista[0] = 0;
            lista[1] = 1;
            Console.Write(lista[0] + " ");
            Console.Write(lista[1] + " ");
            while (i < num)
            {
                //lista[i] = lista[lista.Length - 1] + lista[lista.Length - 2];
                lista[i] = lista[a] + lista[b];
                Console.Write(lista[i] + " ");
                i++;
                a++;
                b++;
            }
        }
    }
}