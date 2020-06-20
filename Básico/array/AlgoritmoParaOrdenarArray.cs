using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg1, msg2;
            msg1 = "Vetor gerado randomicamente";
            msg2 = "Vetor organizado pelo algoritmo do metodo ordenaVet";
            int[] vet = new int[10];
            geraVet(vet);
            exibeVet(vet, msg1);
            ordenaVet(vet);
            exibeVet(vet, msg2);
        }
        static int[] geraVet(int[] vet)
        {
            Random gerador = new Random();
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = gerador.Next(1, 30);
            }
            return vet;
        }
        static int[] ordenaVet(int[] vet)
        {
            int troca = 0;
            for (int j = 0; j < vet.Length; j++)
            {
                for (int t = 0; t < vet.Length; t++)
                {
                    if (vet[j] < vet[t])
                    {
                        troca = vet[j];
                        vet[j] = vet[t];
                        vet[t] = troca;
                    }
                }
            }
            return vet;
        }
        static void exibeVet(int[] vet, string msg)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < vet.Length; i++)
                Console.Write($"{vet[i]} ");
            Console.WriteLine();
        }
    }
}
