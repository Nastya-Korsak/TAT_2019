using System;
using System.Collections.Generic;

namespace Task3
{
    /// <summary>
    /// this class assigns quantity employees of each type
    /// </summary>
    class Company
    {
        List<Employee> employees = new List<Employee> { };
        readonly Employee[] employee = new Employee[50];

        public Company()
        {
            for (int i = 0; i < 20; i++)
            {
                employee[i] = new Junior();
                employees.Add(employee[i]);
            }
            for (int i = 20; i < 35; i++)
            {
                employee[i] = new Middle();
                employees.Add(employee[i]);
            }
            for (int i = 35; i < 45; i++)
            {
                employee[i] = new Senior();
                employees.Add(employee[i]);
            }
            for (int i = 45; i < 50; i++)
            {
                employee[i] = new Lead();
                employees.Add(employee[i]);
            }
        }

        public List<Employee> GetEmployes(Optimizer optimizer, int obj)
        {
            return optimizer.Choose(employees, obj);
        }
        /// <summary>
        /// this method counts employees of each type and prints it
        /// </summary>
        /// <param name="employees"></param>
        public void CountAndPrint(List<Employee> employees)
        {
            int lead = 0;
            int senior = 0;
            int middle = 0;
            int junior = 0;

            foreach(Employee var in employees)
            {
                if (var is Lead)
                {
                    lead += 1;
                    continue;
                }
                if (var is Senior)
                {
                    senior += 1;
                    continue;
                }
                if (var is Middle)
                {
                    middle += 1;
                    continue;
                }
                if (var is Junior)
                {
                    junior += 1;
                    continue;
                }
            }
            Console.WriteLine("Lead=" + lead);
            Console.WriteLine("Senior="+ senior);
            Console.WriteLine("Middle="+ middle);
            Console.WriteLine("Junior="+ junior);
        }
    }
}
