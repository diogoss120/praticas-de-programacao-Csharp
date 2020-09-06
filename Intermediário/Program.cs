using System;
using System.Collections.Generic;

namespace Estagio
{
    class Program
    {
        static void Main(string[] args)
        {
            int ini = 2;
            int max = 120;
            List<int> lista = new List<int>();

            //preenchendo o List
            for (; ini <= max; ini++)
            {
                lista.Add(ini);
            }

            //descobrindo a raiz quadrada de 120
            double raiz = Math.Floor(Math.Sqrt(120));

            //fazendo a remoção dos números que não são primos
            for (ini = 0; ini <= raiz; ini++)
            {
                int temporaria = lista[ini]; //variavel temporaria que serve de inicio para o for do meio
                int parada = 120 / lista[ini]; //variavel que serve de condição de parada para o for do meio
                
                for (int i = temporaria; i <= parada; i++) //for que faz a remoção dos números
                {
                    int result = temporaria * i;
                    lista.Remove(result);
                }
            }

            foreach (int temp in lista) //listando os números restantes
            {
                Console.Write(temp + "  ");
            }
        }
    }
}
