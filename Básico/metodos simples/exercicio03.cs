/*Escreva um algoritmo que possua:
a. Um método para preencher um vetor com números aleatórios.
b. Um método que receba o vetor como argumento e que retorne o menor
valor do vetor.
c. Um método que receba o vetor como argumento e que retorne o maior
valor do vetor.
O retorno dos métodos deve ser apresentado na tela*/

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            preecher();
        }
        static void preecher()
        {
            int[] lista = new int[15];
            Random randNum = new Random();
            for (int i = 0; i < 15; i++)
            {
                lista[i] = randNum.Next(1, 121);
                Console.Write(lista[i]+" ");
            }
            Menor(lista);
            Maior(lista);
        }
        static void Menor(int [] mat)
        {
            int menor = mat[0];
            for(int i = 1; i < mat.Length - 1; i++)
            {
                if (mat[i] < menor)
                    menor = mat[i];
            }
            Console.WriteLine($"\nO menor valor do vetor é: {menor}");
        }
        static void Maior(int [] mat)
        {
            int maior = mat[0];
            for (int i = 1; i < mat.Length - 1; i++)
            {
                if (mat[i] > maior)
                    maior = mat[i];
            }
            Console.WriteLine($"O maior valor do vetor é: {maior}");
        }
    }
}