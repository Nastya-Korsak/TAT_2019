using System;

namespace Task3
{
    class Lead: Senior
    {
        public Lead()
        {
            salary = 330;
            efficiency = 4;
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
