using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Assignment
{
    internal class Employee
    {
        #region Fields
        int employeeID;
        string employeeName;
        int age;
        int departmentChoice;
        double baseSalary;
        int roleChoice;
        double finalSalary;
        #endregion

        #region Properties
        public int EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }

        public string EmployeeName
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value < 21)
                {
                    Console.WriteLine("Employee is not eligible to work.");
                    return;
                }
                else
                {
                    age = value;
                }
            }
        }

        public double BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                baseSalary = value;
            }
        }

        public int DepartmentChoice
        {
            get
            {
                return roleChoice;
            }
            set
            {
                roleChoice = value;
            }
        }

        public int RoleChoice
        {
            get
            {
                return departmentChoice;
            }
            set
            {
                departmentChoice = value;
            }
        }
        #endregion

        #region Methods
        public void DepartmentInput()
        {
            
            Console.WriteLine("----Department Menu----");
            Console.WriteLine("1. IT\n2. HR\n3. Finance");
            Console.Write("Enter your choice : ");
            DepartmentChoice = Int32.Parse(Console.ReadLine());

            switch (DepartmentChoice)
            {
                case 1:
                    Console.WriteLine("----Role Selection Menu----");
                    Console.WriteLine("1. Developer\n2. Tester");
                    Console.Write("Enter your choice : ");
                    this.RoleChoice = Int32.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("----Role Selection Menu----");
                    Console.WriteLine("1. Recruiter\n2. Payroll");
                    Console.Write("Enter your choice : ");
                    this.RoleChoice = Int32.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("----Role Selection Menu----");
                    Console.WriteLine("1. Accountant\n2. Auditor");
                    Console.Write("Enter your choice : ");
                    this.RoleChoice = Int32.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Ivalid choice!");
                    return;
            }
            
        }

        public void salaryCalc()
        {
            switch (DepartmentChoice)
            {
                case 1:
                    switch (RoleChoice)
                    {
                        case 1:
                            this.finalSalary = baseSalary + (baseSalary * 30 / 100);
                            Console.WriteLine("Final Salary : "+finalSalary);
                            break;
                        case 2:
                            this.finalSalary = baseSalary + (baseSalary * 25 / 100);
                            Console.WriteLine("Final Salary : " + finalSalary);
                            break;
                    }
                    break;

                case 2:
                    switch (roleChoice)
                    {
                        case 1:
                            this.finalSalary = baseSalary + (baseSalary * 20 / 100);
                            Console.WriteLine("Final Salary : " + finalSalary);
                            break;
                        case 2:
                            this.finalSalary = baseSalary + (baseSalary * 22 / 100);
                            Console.WriteLine("Final Salary : " + finalSalary);
                            break;
                    }
                    break;

                case 3:
                    switch (roleChoice)
                    {
                        case 1:
                            this.finalSalary = baseSalary + (baseSalary * 28 / 100);
                            Console.WriteLine("Final Salary : " + finalSalary);
                            break;
                        case 2:
                            this.finalSalary = baseSalary + (baseSalary * 26 / 100);
                            Console.WriteLine("Final Salary : " + finalSalary);
                            break;
                    }
                    break;
            }
        }

        public void AccessLevel()
        {
            if(finalSalary >= 60000 && DepartmentChoice == 1)
            {
                Console.WriteLine("Employee has Admin Level Access");
            }
            else if(finalSalary >= 60000 && DepartmentChoice != 1)
            {
                Console.WriteLine("Employee has Manager Level Access");
            }
            else
            {
                Console.WriteLine("Employee has only Employee Level Access");
            }
        }
        #endregion
    }
}
