﻿using System;
using System.Collections.Generic;

namespace Task3
{
    /// <summary>
    /// class for choose employees uses criteria count of efficiency and minimum cost
    /// </summary>
    class EfficiencyAndMinCostCriterion : Optimizer
    {
        public override List<Employee> Choose(List<Employee> employees, int efficiency)
        {
            List<Employee> workingEmployees = new List<Employee> { };
            Junior junior = new Junior();
            Middle middle = new Middle();
            Senior senior = new Senior();
            Lead lead = new Lead();
            Employee checkEmployee;

            while (efficiency != 0)
            {
                if (efficiency>=lead.Efficiency && null != (checkEmployee = employees.Find(item => item.Salary == lead.Salary)))
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
                else
                {
                    if (null != (checkEmployee = employees.Find(item => item.Salary == middle.Salary)))
                    {
                        efficiency -= junior.Efficiency;
                        workingEmployees.Add(checkEmployee);
                        employees.Remove(checkEmployee);
                        continue;
                    }
                }
            }
            return workingEmployees;
        }
    }
}
