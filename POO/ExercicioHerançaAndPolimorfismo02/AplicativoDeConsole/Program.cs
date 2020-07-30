using AplicativoDeConsole.Entities;
using System;
using System.Collections.Generic;

namespace AplicativoDeConsole
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of tax payers: ");
            int qtd = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIn = double.Parse(Console.ReadLine());
                if (c == 'c')
                {
                    Console.Write("Numbers of Employes: ");
                    int emps = int.Parse(Console.ReadLine());
                    list.Add(new Comanies(name, anualIn, emps));
                }
                else
                {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIn, expenditures));
                }
            }
            Console.WriteLine();

            double sum = 0;
            Console.WriteLine("Taxes Payed: ");
            foreach (TaxPayer payer in list)
            {
                Console.WriteLine(payer.Name + ": $" + payer.Tax().ToString("F2"));
                sum += payer.Tax();
            }
            Console.WriteLine("\nTotal Taxes: $" + sum);
        }
    }
}