using System;
using System.Collections.Generic;
using System.Text;

namespace AplicativoDeConsole.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpendules { get; set; }

        public Individual(string name, double anualIncome , double healthExpendules) 
            : base(name, anualIncome)
        {
            HealthExpendules = healthExpendules;
        }

        public override double Tax()
        {
            double taxes = 0;
            if (AnualIncome >= 20000)
                taxes += AnualIncome * 0.25;
            else
                taxes += AnualIncome * 0.15;

            if (HealthExpendules > 0)
                taxes -= HealthExpendules * 0.5;

            return taxes;
        }
    }
}
