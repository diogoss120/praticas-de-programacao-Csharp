using System;
/*Crie um programa que preencha uma matriz 10 x 20 com números inteiros e
some cada uma das linhas, armazenando o resultado das somas em um vetor. A seguir,
o programa deverá multiplicar cada elemento da matriz pela soma da linha
correspondente e mostrar a matriz resultante.*/
namespace AplicativoDeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = preencherMat();
            Console.WriteLine("Matriz original: ");
            exibir(mat);
            int[] soma = somaLinhas(mat);
            Console.WriteLine("Matriz multiplicada pela soma das suas linhas: ");
            multiplicar(mat, soma);
            exibir(mat);
        }
        static int[,] preencherMat()
        {
            int[,] mat = new int[10, 20];
            Random al = new Random();
            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(1); j++)
                    mat[i, j] = al.Next(1, 10);
            return mat;
        }
        static int[] somaLinhas(int[,] mat1)
        {
            int[] soma = new int[10];
            for (int i = 0; i < mat1.GetLength(0); i++)
                for (int j = 0; j < mat1.GetLength(1); j++)
                    soma[i] += mat1[i, j];

            Console.WriteLine("Soma das linhas: ");
            foreach (int valor in soma)
                Console.Write(valor+" ");
            Console.WriteLine();
            return soma;
        }
        static void multiplicar(int[,] mat, int[] soma)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
                for (int j = 0; j < mat.GetLength(1); j++)
                    mat[i, j] *= soma[i];
        }
        static void exibir(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                    Console.Write(mat[i, j] + "  ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}