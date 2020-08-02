using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ExercicioLambdComLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            using (StreamReader reader = File.OpenText(@"D:\exercicio.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string[] funcionario = reader.ReadLine().Split(',');
                    string nome = funcionario[0];
                    string email = funcionario[1];
                    double salario = double.Parse(funcionario[2], CultureInfo.InvariantCulture);
                    employees.Add(new Employee(nome, email, salario));
                }
            }

            ExibirEmployee(employees, "Lista completa de nomes, emails e salarios ");

            var emails = employees.Where(e => e.Salaly > 3000).OrderBy(e => e.Email).Select(e => e.Email);
            var nomes = employees.Where(e => e.Nome[0] == 'A').Sum(e => e.Salaly);

            ExibirEmployee(emails, "Email das pessoas que ganham mais de 3000 reais");
            Console.WriteLine("Soma do salario de todas as pessoas em que a primeira letra do nome é a A: "
                + nomes);
            Console.WriteLine();
        }
        public static void ExibirEmployee<T>(IEnumerable<T> emp, string msg)
        {
            Console.WriteLine(msg);
            foreach (var e in emp)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }
    }
}
