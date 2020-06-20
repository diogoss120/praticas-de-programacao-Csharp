using System;
/*Faça um programa que preencha dois vetores com cinco elementos numéricos
cada e, depois,ordene-os de maneira crescente. Deverá ser gerado um terceiro vetor com
dez posições, composto pela junção dos elementos dos vetores anteriores, também
ordenado de maneira crescente*/
namespace ConsoleAppExercicio
{
    class Program
    {
        static void Main()
        {
            int[] vetor1 = preencher();
            int[] vetor2 = preencher();
            int[] vetor3 = new int[10];
            ler(vetor1, "Primeiro Array");
            ler(vetor2, "Segundo Array");
            vetor3 = somarVet(vetor1, vetor2);
            ler(vetor3,"Vetor resultante da junção dos 2 primeiros vetores");
        }
        static int[] preencher()
        {
            Random num = new Random();
            int[] vet = new int[5];
            for (int i = 0; i < vet.Length; i++)
                vet[i] = num.Next(1, 15);
            ordena(vet);
            return vet;
        }
        static void ler(int[] vet, in string msg)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < vet.Length; i++)
                Console.Write(vet[i]+" ");
            Console.WriteLine();
        }
        static void ordena(int[] arr)
        {
            int troca = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        troca = arr[i];
                        arr[i] = arr[j];
                        arr[j] = troca;
                    }
                }
            }
        }
        static int[] somarVet(int[] arr1, int[] arr2)
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
            ordena(resultante);
            return resultante;
        }
    }
}
