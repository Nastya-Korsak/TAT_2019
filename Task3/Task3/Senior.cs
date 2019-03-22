using System;

namespace Task3
{
    class Senior: Middle
    {
        public Senior()
        {
            salary = 250;
            efficiency = 3;
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
