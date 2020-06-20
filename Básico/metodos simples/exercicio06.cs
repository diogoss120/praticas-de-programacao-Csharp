/*Escreva um algoritmo que possua:
a. Um método para preencher matrizes quadradas com números aleatórios.
b. Um método que receba uma matriz como argumento e que imprima a
matriz na tela.
c. Um método que receba duas matrizes quadradas como argumentos e que
retorne a matriz resultante da soma das duas matrizes recebidas.
d. Um método para apresentar a matriz resultante na tela. */
using System;

namespace ConsoleApp1
{
    class Program
    {
        static int[,] mat1 = new int[5, 5];
        static int[,] mat2 = new int[5, 5];
        static int[,] mat3 = new int[5, 5];
        static void Main(string[] args)
        {
            preecher();
            mostrarMats();
            somarMats();
            exibirSoma();
        }
        static void preecher()
        {
            Random l = new Random();
            for(int i = 0; i< 5 ; i++ )
            {
                for(int j = 0; j <5; j++)
                {
                    mat1[i, j] = l.Next(0, 100);
                    mat2[i, j] = l.Next(0, 100);
                }
            }
        }
        static void mostrarMats()
        {
            Console.WriteLine("Matriz 01: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mat1[i, j]+"\t"); 
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nMatriz 02: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mat2[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void somarMats()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mat3[i, j] = mat1[i, j] + mat2[i, j];
                }
            }
        }
        static void exibirSoma()
        {
            Console.WriteLine("\nSoma das matrizes: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mat3[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}