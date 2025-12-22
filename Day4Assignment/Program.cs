using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee empObj = new Employee();

            Console.Write("Enter your Employee ID: ");
            empObj.EmployeeID = Int32.Parse(Console.ReadLine());

            Console.Write("Enter your name: ");
            empObj.EmployeeName = Console.ReadLine();

            Console.Write("Enter your age: ");
            empObj.Age = Int32.Parse(Console.ReadLine());

            empObj.DepartmentInput();

            Console.Write("Enter your basic salary: ");
            empObj.BaseSalary = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("----Your Information----");

            Console.WriteLine("Employee ID: "+empObj.EmployeeID);

            Console.WriteLine("Name: "+empObj.EmployeeName);

            switch (empObj.DepartmentChoice)
            {
                case 1:
                    Console.WriteLine("Department: IT");
                    switch (empObj.RoleChoice)
                    {
                        case 1:
                            Console.WriteLine("Role: Developer");
                            break;
                        case 2:
                            Console.WriteLine("Role: Tester");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Department: HR");
                    switch (empObj.RoleChoice)
                    {
                        case 1:
                            Console.WriteLine("Role: Recruiter");
                            break;
                        case 2:
                            Console.WriteLine("Role: Payroll");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Department: Finance");
                    switch (empObj.RoleChoice)
                    {
                        case 1:
                            Console.WriteLine("Role: Accountant");
                            break;
                        case 2:
                            Console.WriteLine("Role: Auditor");
                            break;
                    }
                    break;
            }

            Console.WriteLine("Basic Salary: "+empObj.BaseSalary);
            

            empObj.salaryCalc();

            empObj.AccessLevel();

            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}
