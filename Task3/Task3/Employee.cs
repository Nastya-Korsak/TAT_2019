using System;


namespace Task3
{ 
    /// <summary>
    /// base class 
    /// </summary>
    abstract class Employee
    {
        protected int salary;
        protected int efficiency;

        public virtual int Salary
        {
            get; set;
        }

        public virtual int Efficiency
        {
            get; set;
        }

    }
}
