using System;
/*Faça um programa que receba seis números inteiros e mostre:
• os números pares digitados;
• a soma dos números pares digitados;
• os números ímpares digitados;
• a soma dos números ímpares.*/
namespace ConsoleAppExercicio
{
    class Program
    {
        static void Main()
        {
            int[] vetor = lerVetor();
            int somaPares, somaImpares = 0;
            string pares, impares;
            numeros(vetor, out somaPares, out pares, out somaImpares, out impares);
            Console.WriteLine("Os números pares são {0}e a soma deles é {1}", pares, somaPares);
            Console.WriteLine("Os números impares são {0}e a soma deles é {1}", impares, somaImpares);
        }
        static int[] lerVetor()
        {
            int[] vet = new int[6];
            Random v1 = new Random();
            for (int i = 0; i < vet.Length; i++)
                vet[i] = v1.Next(1, 15);
            return vet;
        }
        static void numeros(int[] vetor, out int somapares, out string pares, out int somaimpares, out string impares)
        {
            somapares = 0; somaimpares = 0; pares = ""; impares = "";
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    pares += vetor[i] + " ";
                    somapares += vetor[i];
                }
                else
                {
                    impares += vetor[i] + " ";
                    somaimpares += vetor[i];
                }
            }
        }
    }
}
