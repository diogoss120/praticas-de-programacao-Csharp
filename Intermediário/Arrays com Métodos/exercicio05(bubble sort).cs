using System;
/*Faça um programa que preencha um vetor com cinco elementos numéricos cada
e, depois, ordene-o de maneira crescente.*/
namespace ConsoleAppExercicio
{
    class Program
    {
        static void Main()
        {
            int[] vet1 = new int[5];
            preencherVet(vet1);
            exibirVet(vet1,"Vetor original: ");
            ordena(vet1);
            exibirVet(vet1,"Vetor ordenado pelo método: ");
        }
        static void preencherVet(int[] arr)
        {
            Random num = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = num.Next(1, 30);
        }
        static void ordena(int[] arr)
        {
            int troca = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if(arr[i] < arr[j])
                    {
                        troca = arr[i];
                        arr[i] = arr[j];
                        arr[j] = troca;
                    }
                }
            }
        }
        static void exibirVet(int[] arr, string txt)
        {
            Console.Write(txt);
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
