/*Escreva o algoritmo que será empregado numa pesquisa entre os habitantes de
uma dada região. Os dados coletados na pesquisa serão a altura e o sexo (0 =
feminino, 1 = masculino) das pessoas. O algoritmo deve ler esses dados da
população a partir do teclado e informar na tela:
a. A menor altura encontrada.
b. A maior altura encontrada.
c. A média da altura das mulheres.
d. A média da altura dos homens.
e. A média da altura da população.
f. O percentual de mulheres na população.
g. O percentual de homens na população.*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, somaH = 0, somaT = 0, somaF = 0;
            int i = 0, h = 0, f = 0, c = 0, teste = 0, k = 0, b = 0;
            string pergunta;
            Console.Write("Quantos homens serão analizados: ");
            h = int.Parse(Console.ReadLine());
            Console.Write("Quantas mulheres serão analizadas: ");
            f = int.Parse(Console.ReadLine());
            int total = f + h;
            double[] homens = new double[h];
            double[] mulheres = new double[f];
            double[] todos = new double[total];
            Console.WriteLine("Informe o sexo da pessoa, e em seguida a altura em metros");
            Console.Write("Comece com:  0 = Mulheres ou 1 = homens: ");
            pergunta = Console.ReadLine();
            if ((pergunta == "0" || pergunta == "1"))
                while (c < 2)
                {
                    if (pergunta == "1")
                    {
                        while (i < h)
                        {
                            Console.Write($"Homem {i + 1}: ");
                            homens[i] = double.Parse(Console.ReadLine());
                            todos[b] = homens[i];
                            somaH += homens[i];
                            somaT += homens[i];
                            b++;
                            i++;
                        }
                        if (teste < 2)
                            pergunta = "0";
                        teste++;
                    }

                    if (pergunta == "0")
                    {
                        while (k < f)
                        {
                            Console.Write($"mulher {k + 1}: ");
                            mulheres[k] = double.Parse(Console.ReadLine());
                            todos[b] = mulheres[k];
                            somaF += mulheres[k];
                            somaT += mulheres[k];
                            b++;
                            k++;
                        }
                        if (teste < 2)
                            pergunta = "1";
                        teste++;
                    }
                    c++;
                }
            else
            {
                try
                {
                    m = double.Parse(pergunta);
                    Console.WriteLine("Você digitou um número diferente de 0 e 1. Tente novamente");
                }
                catch
                {
                    Console.WriteLine($"Você digitou ({pergunta}) para sair, orbigado por participar");
                }
            }
            Array.Sort(homens);
            Array.Sort(mulheres);
            Array.Sort(todos);
            Console.WriteLine($"A menor altura encontrada foi {todos[0]}");
            Console.WriteLine($"A maior altura encontrada foi {todos[todos.Length - 1]}");
            Console.WriteLine("A media da altura dos homens é: " + somaH / h);
            Console.WriteLine("A media da altura das mulheres é: " + somaF / f);
            Console.WriteLine("A media da altura de todos é: " + somaT / b);
            Console.WriteLine("O percentual de homens é: " + (h * 100) / total + "%");
            Console.WriteLine("O percentual de mulheres é: " + (f * 100) / total + "%");
        }
    }
}