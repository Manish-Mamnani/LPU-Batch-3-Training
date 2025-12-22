using System;


namespace Day4Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Manager manager = new Manager();
            Employee employee2 = new Manager();

            int s = employee2.CalculateSalary(200000);

            Console.WriteLine("Salary = "+s);
        }
    }
}
