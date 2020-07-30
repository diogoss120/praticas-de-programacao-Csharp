using InterfaceExercicio.Entyties;
using InterfaceExercicio.Services;
using System;

namespace InterfaceExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime dt = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());

            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, dt, value);

            Console.WriteLine("Installments: ");
            ContractService contractService = new ContractService();

            contractService.ProcesContract(contract, months);

            contract.InstamenstsValues();
        }
    }
}
