using System;
using System.Collections.Generic;

namespace Task3
{
    /// <summary>
    /// this class assigns quantity employees of each type
    /// </summary>
    class Company
    {
        private  List<Employee> employees = new List<Employee> { };
        static int numberOfEmployees = 50;
        readonly Employee[] employee = new Employee[numberOfEmployees];

        /// <summary>
        /// Puts in array different emloyees
        /// </summary>
        public Company()
        {
            int numberOfJunior = 20;
            int numberOfMiddle = 15;
            int numberOfSenior = 10;

            for (int i = 0; i < numberOfJunior; i++)
            {
                employee[i] = new Junior();
                employees.Add(employee[i]);
            }
            for (int i = numberOfJunior; i < numberOfJunior+ numberOfMiddle; i++)
            {
                employee[i] = new Middle();
                employees.Add(employee[i]);
            }
            for (int i = numberOfJunior + numberOfMiddle; i < numberOfJunior + numberOfMiddle + numberOfSenior; i++)
            {
                employee[i] = new Senior();
                employees.Add(employee[i]);
            }
            for (int i = numberOfJunior + numberOfMiddle + numberOfSenior; i < numberOfEmployees; i++)
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
                }
                else
                if (var is Senior)
                {
                    senior += 1;
                }
                else
                if (var is Middle)
                {
                    middle += 1;
                }
                else
                if (var is Junior)
                {
                    junior += 1;
                }
            }
            Console.WriteLine("Lead=" + lead);
            Console.WriteLine("Senior="+ senior);
            Console.WriteLine("Middle="+ middle);
            Console.WriteLine("Junior="+ junior);
        }
    }
}
