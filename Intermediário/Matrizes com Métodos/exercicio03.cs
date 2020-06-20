using System;
/*Elabore um programa que preencha uma matriz 6 x 3, calcule e mostre:
• o maior elemento da matriz e sua respectiva posição, ou seja, linha e coluna;
• o menor elemento da matriz e sua respectiva posição, ou seja, linha e coluna*/
class Program
{
    static void Main()
    {
        int[,] mat = new int[6, 3];
        preencherMat(mat);
        exibirMat(mat, "Matriz original: ");
        analiza(mat);
    }
    static void preencherMat(int[,] mat)
    {
        Random geraNum = new Random();
        for (int i = 0; i < mat.GetLength(0); i++)
            for (int j = 0; j < mat.GetLength(1); j++)
                mat[i, j] = geraNum.Next(1, 45);
    }
    static void exibirMat(int[,] mat, string msg)
    {
        Console.WriteLine(msg);
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                Console.Write($"{mat[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    static void analiza(int[,] mat)
    {
        Posicao menor = new Posicao();
        menor.Numero(mat[0, 0]);
        Posicao maior = new Posicao();
        maior.Numero(mat[0, 0]);
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if (mat[i, j] < menor.ValorNum())
                {
                    menor.Posicoes(i, j, mat[i, j]);
                }
                if (mat[i, j] > maior.ValorNum())
                {
                    maior.Posicoes(i, j, mat[i, j]);
                }
            }
        }
        Console.WriteLine();
        maior.info("maior");
        menor.info("menor");
    }
}
struct Posicao
{
    private int linha;
    private int coluna;
    private int num;
    public void info(string msg)
    {
        Console.WriteLine($"{this.num} é o {msg} número, ele esta na linha {this.linha} e na coluna {this.coluna}");
    }
    public void Numero(int num)
    {
        this.num = num;
    }
    public void Posicoes(int linha, int coluna, int num)
    {
        this.num = num;
        this.linha = linha;
        this.coluna = coluna;
    }
    public int ValorNum()
    {
        return this.num;
    }
}