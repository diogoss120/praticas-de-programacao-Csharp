/*Escreva um algoritmo que possua:
a. Um método para preencher uma matriz quadrada com números aleatórios.
Uma matriz quadrada possui o número de linhas igual ao número de
colunas.
b. Um método que receba a matriz como argumento e que imprima a matriz
na tela.
c. Um método que receba a matriz como argumento e que apresente a
diagonal principal da matriz na tela.
d. Um método que receba a matriz como argumento e que apresente a
diagonal secundária da matriz na tela.*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[,] matriz = new int[5, 5];
            geraNumeros(matriz);
            imprimirMat(matriz);
            diagonal1(matriz);
            diagonal2(matriz);
        }
        static void geraNumeros(int[,] mat)
        {
            int i, j;
            Random gerador = new Random();
            for (i = 0; i < mat.GetLength(0); i++)
            {
                for (j = 0; j < mat.GetLength(0); j++)
                {
                    mat[i, j] = gerador.Next(0, 150);
                }
            }
        }
        static void imprimirMat(int[,] mat)
        {
            int i, j;
            for (i = 0; i < mat.GetLength(0); i++)
            {
                for (j = 0; j < mat.GetLength(0); j++)
                {
                    Console.Write($"{mat[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        static void diagonal1(int[,] mat)
        {
            int i;
            Console.WriteLine("\nNúmeros da diagonal principal: ");
            for (i = 0; i < mat.GetLength(0); i++)
            {
                Console.Write($"{mat[i, i]}\t");
            }
        }
        static void diagonal2(int[,] mat)
        {
            int i, j = 4;
            Console.WriteLine("\nNúmeros da diagonal secundaria: ");
            for (i = 0; i < mat.GetLength(0) ; i++)
            {
                Console.Write($"{mat[i, j]}\t");
                j--;
            }
        }
    }
}


/*Escreva um algoritmo que possua:
a. Um método para preencher uma matriz quadrada com números aleatórios.
Uma matriz quadrada possui o número de linhas igual ao número de
colunas.
b. Um método que receba a matriz como argumento e que imprima a matriz
na tela.
c. Um método que receba a matriz como argumento e que apresente a
diagonal principal da matriz na tela.
d. Um método que receba a matriz como argumento e que apresente a
diagonal secundária da matriz na tela.*/
