/*Escreva um algoritmo em C# que leia os elementos inteiros de uma matriz 5 x 3 a partir do teclado e os armazene na matriz. O algoritmo deve:
1)Apresentar a matriz original na tela.
2)Elevar cada elemento armazenado na matriz ao quadrado.
3)Apresentar a matriz modificada na tela.*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[,] matriz = new int[5,3];
            string msg1 = "Vetor original", msg2 = "Vetor modificado";
            gerar(matriz);
            mostrar(matriz, msg1);
            alterarMat(matriz);
            mostrar(matriz, msg2);
        }
        static int [,] gerar(int [,] vet)
        {
            Random gerador = new Random();
            for (int i = 0; i < 5; i++)
                for(int j = 0; j < 3; j++)
                    vet[i, j] = gerador.Next(-3, 15);
            return vet;
        }
        static void mostrar(int [,] vet, string texto)
        {
            Console.WriteLine(texto);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{vet[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        static int[,] alterarMat(int [,] vet)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 3; j++)
                    vet[i, j] *= 3;
            return vet;
        }
    }
}


