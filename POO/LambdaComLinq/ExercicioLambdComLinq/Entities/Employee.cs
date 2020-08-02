using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLambdComLinq
{
   public class Employee
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Salaly { get; set; }

        public Employee(string name, string email, double salary)
        {
            Nome = name;
            Email = email;
            Salaly = salary;
        }

        public override string ToString()
        {
            return $"{Nome}, {Email} - {Salaly}";
        }
    }
}
