using System;
using System.Collections.Generic;


namespace Task3
{
    /// <summary>
    /// class of first criterion
    /// </summary>
    class FirstCriterion : Optimizer
    {
        public override List<Employee> Choose(List<Employee> employees, int money)
        {
            List<Employee> workingEmployees=new List<Employee> { };
            Junior junior = new Junior();
            Middle middle = new Middle();
            Senior senior = new Senior();
            Lead lead = new Lead();
            Employee checkEmployee;
            while (money >= junior.Salary)
            {
                if (money >= lead.Salary && null != (checkEmployee = employees.Find(item => item.Salary == lead.Salary)))
                {                   
                        workingEmployees.Add(checkEmployee);
                        employees.Remove(checkEmployee);
                        money = money - lead.Salary;
                        continue;                   
                }

                if (money >= senior.Salary&& null != (checkEmployee = employees.Find(item => item.Salary == senior.Salary)))
                {
                        workingEmployees.Add(checkEmployee);
                        employees.Remove(checkEmployee);
                        money = money - senior.Salary;
                        continue;
                }

                if (money >= middle.Salary&& null != (checkEmployee = employees.Find(item => item.Salary == middle.Salary)))
                {
                        workingEmployees.Add(checkEmployee);
                        employees.Remove(checkEmployee);
                        money = money - middle.Salary;
                        continue;
                }
                else
                {
                    if (null != (checkEmployee = employees.Find(item => item.Salary == junior.Salary)))
                    {
                        workingEmployees.Add(checkEmployee);
                        employees.Remove(checkEmployee);
                        money = money - junior.Salary;
                        continue;
                    }
                }
            }
            return workingEmployees;
        }
    }
}
