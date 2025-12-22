using System;

namespace Day4Demo
{
    class Manager : Employee
    {
        public int managerID { get; set; }
        public int incentive { get; set; }

        public Manager()
        {
            Console.WriteLine("Derived Class");
        }

        public override int CalculateSalary(int sal)
        {
            int mySal = 0;
            //NetSalary = Salary+HRA+TA+DA-PF
            mySal = sal + 20000 + 8000 + 4500 - 5000;
            return mySal;
        }
    }
}
