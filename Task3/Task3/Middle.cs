using System;

namespace Task3
{
    class Middle: Junior
    {
        public Middle()
        {
            salary = 170;
            efficiency = 2;
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
