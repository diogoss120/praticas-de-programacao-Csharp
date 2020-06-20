/*Algoritmo que encontra o quinto número maior que 1000, cuja divisão
por 11 tenha resto 5*/
using System;
public class Program
{
    public static void Main()
    {
        int i = 1000, teste = 0, numero= 0 ;
        Console.WriteLine($"Algoritmo para encontrar o quinto número maior que 1000, cuja divisão"+
                            "por 11 tenha resto 5");
        while (teste <= 4)
        {
            if (i % 11 == 5)
            {
                teste++;
                if (teste == 5)
                    numero = i;
            }
            i++;
        }
        Console.WriteLine($"O seu número é: {numero}");
    }
}