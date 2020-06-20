using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ult, pen;
            Console.WriteLine("Algoritmo para gerar a sequência de fibonaci");
            var lista = new List<int> { 1, 1 };

            for (int i = 0; i < 20; i++)
            {
                ult = lista.Count - 1;
                pen = lista.Count - 2;
                lista.Add(lista[ult] + lista[pen]);
            }

            for (int i = 0; i < 20; i++)
                Console.Write(lista[i] + " ");
        }
    }
}
