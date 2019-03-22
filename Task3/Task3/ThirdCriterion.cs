using System;
using System.Collections.Generic;

namespace Task3
{
    /// <summary>
    /// class of third criterion
    /// </summary>
    class ThirdCriterion : Optimizer
    {
        public override List<Employee> Choose(List<Employee> employees, int efficiency)
        {
            List<Employee> workingEmployees = new List<Employee> { };
            Middle middle = new Middle();
            Senior senior = new Senior();
            Lead lead = new Lead();
            Employee checkEmployee;

            while (efficiency > 1)
            {
                if (efficiency >= lead.Efficiency && null != (checkEmployee = employees.Find(item => item.Salary == lead.Salary)))
                {
                    efficiency -= lead.Efficiency;
                    workingEmployees.Add(checkEmployee);
                    employees.Remove(checkEmployee);
                    continue;
                }
                if (efficiency >= senior.Efficiency && null != (checkEmployee = employees.Find(item => item.Salary == senior.Salary)))
                {
                    efficiency -= senior.Efficiency;
                    workingEmployees.Add(checkEmployee);
                    employees.Remove(checkEmployee);
                    continue;
                }
                if (efficiency >= middle.Efficiency && null != (checkEmployee = employees.Find(item => item.Salary == middle.Salary)))
                {
                    efficiency -= middle.Efficiency;
                    workingEmployees.Add(checkEmployee);
                    employees.Remove(checkEmployee);
                    continue;
                }
            }
            return workingEmployees;
        }
    }
}
