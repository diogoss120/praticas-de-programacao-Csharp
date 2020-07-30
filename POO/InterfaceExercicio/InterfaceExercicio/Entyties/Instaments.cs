using System;

namespace InterfaceExercicio.Entyties
{
    class Instaments
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Instaments(DateTime dateTime, double amount)
        {
            Amount = amount;
            DueDate = dateTime;
        }
    }
}
