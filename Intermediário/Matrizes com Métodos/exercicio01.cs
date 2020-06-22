using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = preecher();
            Console.WriteLine("Vetor original:");
            ler(mat);
            trocaLinha2e8(mat);
            trocaColuna4e10(mat);
            trocaDiagonalPcomS(mat);
            Col10comLin5(mat);
        }
        static int[,] preecher()
        {
            int[,] mat = new int[10, 10];
            Random al = new Random();
            for (int i = 0, j; i < mat.GetLength(0); i++)
                for (j = 0; j < mat.GetLength(1); j++)
                    mat[i, j] = al.Next(10, 30);
            return mat;
        }
        static void ler(int[,] mat)
        {
            for (int i = 0, j; i < mat.GetLength(0); i++)
            {
                Console.Write($"Linha {i}:  ");
                for (j = 0; j < mat.GetLength(1); j++)
                    Console.Write(mat[i, j] + "  ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void trocaLinha2e8(int[,] mat)
        {
            int[] troca = new int[10];
            for (int i = 0, j; i < mat.GetLength(0); i++)
                for (j = 0; j < mat.GetLength(1); j++)
                {
                    if (i == 1)
                    {
                        troca[j] = mat[i, j];
                    }
                    if (i == 7)
                    {
                        mat[1, j] = mat[i, j];
                        mat[i, j] = troca[j];
                    }
                }
            Console.WriteLine("Vetor com as linhas 1 e 7 trocadas");
            ler(mat);
        }
        static void trocaColuna4e10(int[,] mat)
        {
            int[] troca = new int[10];
            for (int i = 0, j; i < mat.GetLength(0); i++)
                for (j = 0; j < mat.GetLength(1); j++)
                {
                    if (j == 3)
                    {
                        troca[i] = mat[i, j];
                    }
                    if (j == 8)
                    {
                        mat[i, 3] = mat[i, j];
                        mat[i, j] = troca[i];
                    }
                }
            Console.WriteLine("Vetor com as colunas 4 e 10 trocadas");
            ler(mat);
        }
        static void trocaDiagonalPcomS(int[,] mat)
        {
            int t = 0;
            for (int i = 0, j = 0, p = mat.GetLength(0)- 1; i < mat.GetLength(0); j++, i++, p--)
                for ( ; j < mat.GetLength(1); )
                {
                    t = mat[i, j];
                    mat[i,j] = mat[i, p];
                    mat[i, p] = t;
                    break;
                }
            Console.WriteLine("Diagonal principal e secundaria trocadas");
            ler(mat);
        }
        static void Col10comLin5(int[,] mat)
        {
            int troca = 0;
            for(int i= 0, c =0; i < mat.GetLength(0); i++, c++)
            {
                troca = mat[3, i];
                mat[3, i] = mat[i, 9];
                mat[i, 9] = troca;
            }
            Console.WriteLine("Coluna 10 trocada com linha 5");
            ler(mat);
        }
    }
}
