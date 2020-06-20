/*Escreva um algoritmo que possua:
a. Um método para preencher uma matriz quadrada com números aleatórios.
b. Um método que receba a matriz como argumento e que imprima a matriz
na tela.
c. Um método que receba a matriz como argumento e que multiplique por -1
todos os elementos com índice da linha menor ou igual ao índice da
coluna.
A matriz original e a matriz resultante devem ser apresentadas na tela.*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[,] matriz = new int[5, 5];
            gerarNum(matriz);
            exibir(matriz);
            alterarMat(matriz);
            exibir(matriz);
        }
        static int [,] gerarNum(int [,] mat)
        {
            Random gerador = new Random();
            for(int i = 0; i < mat.GetLength(0) ; i++ )
            {
                for (int j = 0; j < mat.GetLength(0); j++)
                    mat[i, j] = gerador.Next(-25, 100);
            }
            return mat;
        }
        static void exibir (int [,] mat)
        {
            Console.WriteLine("Matriz: ");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(0); j++)
                    Console.Write($"{mat[i, j]}\t");
                Console.WriteLine();
            }
        }
        static void alterarMat(int [,] mat)
        {
            int j = 0, i, x =0;
            for (i = 0; i < mat.GetLength(0); i++)
            {
                for (j = x; j < mat.GetLength(0); j++)
                {
                    mat[i, j] *= -1;
                    
                }
                x++;
                Console.WriteLine();
            }
        }
    }
}

