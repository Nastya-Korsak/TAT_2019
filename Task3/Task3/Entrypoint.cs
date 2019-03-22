using System;
using System.Collections.Generic;

namespace Task3
{
    /// <summary>
    /// Entrypoint
    /// </summary>
    class Entrypoint
    {
        /// <summary>
        /// main
        /// </summary>
        /// <param name="args">Inputed number of ctriterion</param>
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 1) throw new FormatException();
                Company company = new Company();
                int number = Convert.ToInt32(args[0]);
                int summa = 1000;
                int efficiency = 10;
                 Optimizer optimizer;
                List<Employee> employees = new List<Employee> { };
                switch (number)
                {
                    case 1:
                        optimizer = new FirstCriterion();
                        employees=company.GetEmployes(optimizer, summa);
                        company.CountAndPrint(employees);
                        return;
                    case 2:
                        optimizer = new SecondCriterion();
                        employees=company.GetEmployes(optimizer, efficiency);
                        company.CountAndPrint(employees);
                        return;
                    case 3:
                        optimizer = new ThirdCriterion();
                        employees = company.GetEmployes(optimizer, efficiency);
                        company.CountAndPrint(employees);
                        return;
                    default: throw new FormatException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You didn't choose criterion or you have bad data!");
            }
        }
    }
}
