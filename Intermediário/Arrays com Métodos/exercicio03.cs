using System;
/*Faça um programa que preencha um vetor com dez números inteiros, calcule e
mostre os números superiores a cinquenta e suas respectivas posições. O programa
deverá mostrar mensagem se não existir nenhum número nessa condição.*/
namespace ConsoleAppExercicio
{
    class Program
    {
        static void Main()
        {
            int[] vet1 = new int[10];
            preencherVet(vet1);
            exibirVet(vet1);
            analizar(vet1);
        }
        static void preencherVet(int[] arr)
        {
            Random num = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = num.Next(1, 100);
        }
        static void exibirVet(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + "  ");
            Console.WriteLine();
        }
        static void analizar(int[] vet)
        {
            int total = 0;
            string pos = "", numeros = "";
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] > 50)
                {
                    total += vet[i];
                    numeros += vet[i] + " ";
                    pos += i + " ";
                }
            }
            Console.WriteLine("Soma dos números maiores que 50: {0}", total);
            Console.WriteLine("Posição dos números maiores que 50: {0}", pos);
            Console.WriteLine("Números maiores que 50: {0}", numeros);
        }
    }
}
