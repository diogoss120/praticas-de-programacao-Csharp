using System;
/*Crie um programa que preencha duas matrizes 3 x 8 com números inteiros,
calcule e mostre:
• a soma das duas matrizes, resultando em uma terceira matriz também de ordem
3 x 8;
• a diferença das duas matrizes, resultando em uma quarta matriz também de
ordem 3 x 8.*/
namespace AplicativoDeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat1 = preencherMat();
            int[,] mat2 = preencherMat();
            exibirMats(mat1);
            exibirMats(mat2);
            somaMats(mat1, mat2);
            diferencaMats(mat1, mat2);
        }
        static int[,] preencherMat()
        {
            int[,] mat = new int[3, 8];
            Random al = new Random();
            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(1); j++)
                    mat[i, j] = al.Next(1, 20);
            return mat;
        }
        static void somaMats(int[,] mat1, int[,] mat2)
        {
            Console.WriteLine("Soma da matriz1 com a matriz 2:");
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                    Console.Write(mat1[i,j] + mat2[i,j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void diferencaMats(int[,] mat1, int[,] mat2)
        {
            Console.WriteLine("Soma da matriz1 com a matriz 2:");
            for (int i = 0; i < mat1.GetLength(0); i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                    Console.Write(mat1[i, j] - mat2[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void exibirMats(int[,] mat)
        {
            Console.WriteLine("Matriz original: ");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                    Console.Write(mat[i, j]+" ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
