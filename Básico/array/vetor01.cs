using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[] vetor = new int[10];
            string msg1 = "Vetor original", msg2 = "\nVetor multiplicado por 3";
            gerar(vetor);
            mostrar(vetor, msg1);
            multiplicaPortres(vetor);
            mostrar(vetor, msg2);
        }
        static int [] gerar(int [] vet)
        {
            Random gerador = new Random();
            for (int i = 0; i < vet.Length; i++)
                vet[i] = gerador.Next(-11, 20);
            return vet;
        }
        static void mostrar(int [] vet, string texto)
        {
            Console.WriteLine(texto);
            for (int i = 0; i < vet.Length; i++)
                Console.Write($"{vet[i]} ");
            Console.WriteLine();
        }
        static void multiplicaPortres(int [] vet)
        {
            for (int i = 0; i < vet.Length; i++)
                vet[i] *= 3;
        }
    }
}


