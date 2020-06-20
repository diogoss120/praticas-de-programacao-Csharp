using System;
/*Faça um programa que, no momento de preencher um vetor com oito números
inteiros, já os armazene de forma crescente.*/
namespace ConsoleAppExercicio
{
    class Program
    {
        static void Main()
        {
            int[] vet1 = new int[8];
            preencherVet(vet1);
            exibirVet(vet1);
        }
        static void preencherVet(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Preencha a pos {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
                ordena(arr, i);
            }
        }
        static void ordena(int[] arr , in int num)
        {
            int troca = 0;
            for (int i = num; i >= 0; i--)
            {
                for (int j = num; j >= 0; j--)
                {
                    if (arr[i] > arr[j])
                    {
                        troca = arr[i];
                        arr[i] = arr[j];
                        arr[j] = troca;
                    }
                }
            }
        }
        static void exibirVet(int[] arr)
        {
            Console.Write("Vetor: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
