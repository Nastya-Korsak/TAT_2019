using System;
using System.Collections.Generic;

namespace Task3
{
    /// <summary>
    /// base class for criterions
    /// </summary>
    abstract class Optimizer
    {
        abstract public List<Employee> Choose(List<Employee> employees, int obj);
    }
}
