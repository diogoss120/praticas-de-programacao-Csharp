using System;
/*Faça um programa que preencha uma matriz 3 x 5 com números inteiros, calcule
e mostre a quantidade de elementos entre 15 e 20.*/
class Program
{
    static void Main()
    {
        int[,] mat = new int[3, 5];
        int soma; string numeros;
        preencherMat(mat);
        exibirMat(mat, "Matriz original: ", out soma, out numeros);
        Console.WriteLine($"Os numeros maiores que 15 são: {numeros}, e a soma deles é {soma} ");
    }
    static void preencherMat(int[,] mat)
    {
        Random geraNum = new Random();
        for (int i = 0; i < mat.GetLength(0); i++)
            for (int j = 0; j < mat.GetLength(1); j++)
                mat[i, j] = geraNum.Next(5, 25);
    }
    static void exibirMat(int[,] mat, string msg, out int soma, out string numeros)
    {
        soma = 0; numeros = "";
        Console.WriteLine(msg);
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write($"{mat[i, j]} ");
                if (mat[i, j] > 15)
                {
                    soma += mat[i, j];
                    numeros += mat[i, j] + " ";
                }
            }
            Console.WriteLine();
        }
    }
}