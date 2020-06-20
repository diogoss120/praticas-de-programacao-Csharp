using System;
/*Faça um programa que preencha dois vetores de cinco elementos numéricos
cada um e mostra o vetor resultante da intercalação deles*/
namespace ConsoleAppExercicio
{
    class Program
    {
        static void Main()
        {
            int[] vet1 = new int[5];
            int[] vet2 = new int[5];
            vet(vet1);
            vet(vet2);
            exibirVet(vet1);
            exibirVet(vet2);
            somarVet(vet1, vet2);
        }
        static void vet(int[] arr)
        {
            Random num = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = num.Next(1, 20);
        }
        static void somarVet(int[] arr1, int[] arr2)
        {
            int[] resultante = new int[10];
            int i = 0; ;

            for (i = 0; i < arr1.Length; i++)
                resultante[i] = arr1[i];

            for (int j = 0; j < arr2.Length; j++)
            {
                resultante[i] = arr2[j];
                i++;
            }
            exibirVet(resultante);
        }
        static void exibirVet(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + "  ");
            Console.WriteLine();
        }
    }
}
