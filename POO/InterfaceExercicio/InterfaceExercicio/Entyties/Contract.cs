using System;
using System.Collections.Generic;

namespace InterfaceExercicio.Entyties
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Instaments> Instaments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Instaments = new List<Instaments>();
        }

        public void InstamenstsValues()
        {
            foreach(Instaments inst in Instaments)
            {
                Console.WriteLine(inst.DueDate + " - " + inst.Amount);
            }
        }
    }
}
