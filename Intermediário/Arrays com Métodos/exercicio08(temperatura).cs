using System;
/*Faça um programa que receba a temperatura média de cada mês do ano,
armazenando-as em um vetor. Calcule e mostre a maior e a menor temperatura do ano e
em que mês ocorreram*/
namespace ConsoleAppExercicio
{
    class Program
    {
        static void Main()
        {
            int[] vet = preencher();
            ler(vet, "Lendo todas as temperaturas");
            analise(vet);
        }
        static void ler(int[] vet, in string msg)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < vet.Length; i++)
                Console.WriteLine($"{mes(i)}: {vet[i]}");
            Console.WriteLine();
        }
        static int[] preencher()
        {
            Random num = new Random();
            int[] vet = new int[12];
            for (int i = 0; i < vet.Length; i++)
                vet[i] = num.Next(15, 35);
            return vet;
        }
        static void analise(int[] vet)
        {
            int maiorTemp = vet[0], menorTemp = vet[0],  i = 0;
            string posMenor = "", posMaior = "";
            for (i = 0; i < vet.Length; i++)
            {
                if (vet[i] < menorTemp)
                {
                    menorTemp = vet[i];
                    posMenor = mes(i);
                }
                if (vet[i] > maiorTemp)
                {
                    maiorTemp = vet[i];
                    posMaior = mes(i);
                }
            }
            Console.WriteLine($"A maior temperatura foi {maiorTemp} graus no mês de {posMaior}");
            Console.WriteLine($"A menor temperatura foi {menorTemp} graus no mês de {posMenor}");
        }
        static string mes(in int numero)
        {
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho",
                "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            string msg = meses[numero];
            return msg;
        }
    }
}
