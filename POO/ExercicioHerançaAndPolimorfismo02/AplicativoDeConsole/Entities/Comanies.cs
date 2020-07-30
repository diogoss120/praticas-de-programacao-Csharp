using System;
using System.Collections.Generic;
using System.Text;

namespace AplicativoDeConsole.Entities
{
    class Comanies : TaxPayer
    {
        public int NumbersOfEmployees { get; set; }

        public Comanies(string name, double anualIncome , int numbersOfEmployees)
            :base(name, anualIncome)
        {
            NumbersOfEmployees = numbersOfEmployees;
        }
        public override double Tax()
        {
            double taxes = 0;
            if (NumbersOfEmployees >= 10)
                taxes += AnualIncome * 0.14;
            else
                taxes += AnualIncome * 0.16;

            return taxes;
        }
    }
}
