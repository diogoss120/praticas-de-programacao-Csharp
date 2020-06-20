/*Escreva um algoritmo que possua um método para inversão dos dígitos de um
número inteiro. O método deve receber o número inteiro como argumento e
retornar o número correspondente à inversão dos dígitos do número recebido. O
algoritmo deve ser executado quantas vezes o usuário desejar.*/
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int p = 0;
            string texto;
            do
            {
                Console.Write("Informe o número e ele será exibido invertido: ");
                p = int.Parse(Console.ReadLine());
            } while (p <= 0);
            texto = p.ToString();
            Inverte(texto);
        }
        static void Inverte(string p)
        {
            char[] lista = p.ToCharArray();
            Array.Reverse(lista);
            foreach(char t in lista)
                Console.Write(t);
        }
    }
}