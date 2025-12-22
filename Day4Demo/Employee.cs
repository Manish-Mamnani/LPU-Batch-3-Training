using System;
using System.Threading;


namespace Day4Demo
{
    class Employee
    {
        #region Properties
        public int empID { get; set; }
        public string name { get; set; }
        #endregion

        public Employee()
        {
            Console.WriteLine("Base Class");
        }

        public virtual int CalculateSalary(int sal)
        {
            int mySal = 0;
            //NetSalary = Salary+HRA+TA+DA-PF
            mySal = sal+15000+3000+1500-2500;
            return mySal;
        }
    }
}