using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            /*int[][] matriz = new int[][] 
              {
               new int[] { 1, 3, 5, 7, 9 },
               new int[] { 0, 2, 4, 6 },
               new int[] { 11, 22 }
              };*/
            int[][] matriz = new int[3][];
            matriz[0] = new int[4];
            matriz[1] = new int[5];
            matriz[2] = new int[3];
            preencherArray(matriz);
            mostrar(matriz);
        }
        static int[][] preencherArray(int[][] mat)
        {
            Random gerador = new Random();
            int i, j;
            for (i = 0; i < mat.Length; i++)
            {
                for (j = 0; j < mat[i].Length; j++)
                {
                    mat[i][j] = gerador.Next(0, 20);
                }
                Console.WriteLine();
            }
            return mat;
        }
        static void mostrar(int [][] mat)
        {
            int i, j;
            for (i = 0; i < mat.Length; i++)
            {
                for (j = 0; j < mat[i].Length; j++)
                {
                    Console.Write($"{mat[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}


