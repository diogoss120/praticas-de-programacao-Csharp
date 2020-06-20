using System;
/* Faça um programa que gere os dez primeiros números primos acima de 100 e
armazene-os em um vetor. Escreva no final o vetor resultante*/
class Program
{
    static void Main()
    {
        int[] vetor = Geranum(); // O metodo Geranum retorna um vetor completo
        mostrar(vetor);
    }
    static int[] Geranum()
    {
        int[] arr = new int[10];
        for (int i = 100, j = 0; j < arr.Length; i++) // iniciei 2 variaveis dentro do mesmo for (i e j)
        {
            if (valida(in i)) // todo IF retorna um True ou False, sendo assim, coloquei diretamente o metodo
                arr[j++] = i; // valida(i) dentro da condição do if ao inves de uma variavel, PORQUE o metodo
        }                     // vai retornar um Bool e o if vai verificar se é true ou false
        return arr;           // coloquei dentro do arr[j++] porque o J vai ser usado e depois incrementado
    }
    static bool valida(in int num)
    {
        for (int j = 2; j < num; j++)
        {
            if (num % j == 0)
                return false; // usei o return para retornar um bool para o metodo, como ele só é
        }                     // usado 1 vez não foi necessário usar uma variavel
        return true;
    }
    static void mostrar(int[] vet)
    {
        Console.WriteLine("Números primos");
        for (int j = 0; j < vet.Length; j++)
            Console.Write($"{vet[j]} ");
    }
}