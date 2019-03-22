using System;

namespace Task3
{
    class Junior: Employee
    {
        public Junior()
        {
            salary = 100;
            efficiency = 1;
        }
        public override int Salary
        {
            get
            {
                return salary;
            }
        }

        public override int Efficiency
        {
            get
            {
                return efficiency;
            }
        }
    }
}
