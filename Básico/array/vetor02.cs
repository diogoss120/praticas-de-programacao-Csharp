using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[] vetor = new int[10];
            string msg1 = "Vetor original";
            gerar(vetor);
            mostrar(vetor, msg1);
            testes(vetor);
        }
        static int [] gerar(int [] vet)
        {
            Random gerador = new Random();
            for (int i = 0; i < vet.Length; i++)
                vet[i] = gerador.Next(-4, 10);
            return vet;
        }
        static void mostrar(int [] vet, string texto)
        {
            Console.WriteLine(texto);
            for (int i = 0; i < vet.Length; i++)
                Console.Write($"{vet[i]} ");
            Console.WriteLine();
        }
        static void testes(int [] vet)
        {
            int numImpares = 0, numerosPositivos = 0, quantidadePositivos = 0, numerosNegativos=0;
            string numPares = " ";
            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] % 2 == 1)
                {
                    numImpares++;
                }
                else
                    numPares += i + " ";
                if (vet[i] >= 0)
                {
                    numerosPositivos += vet[i];
                    quantidadePositivos++;
                }
                else
                    numerosNegativos += vet[i];
            }
            Console.WriteLine($"O vetor contem {numImpares} números impares");
            Console.WriteLine($"As posições dos números pares são {numPares}");
            Console.WriteLine($"A média aritmética dos números positivos: {numerosPositivos/quantidadePositivos}");
            Console.WriteLine($"O quadrado dasoma dos números negativos: { Math.Pow(numerosNegativos, 2)}");
        }
    }
}


