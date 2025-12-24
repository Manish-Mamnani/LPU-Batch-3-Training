using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDay6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string title, author, due, returned;
            int numOfPages;
            

            Console.WriteLine("Enter title");
            title = Console.ReadLine();

            Console.WriteLine("Enter author");
            author = Console.ReadLine();

            Console.WriteLine("Enter number of pages");
            numOfPages = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter due date");
            due = Console.ReadLine();

            Console.WriteLine("Enter date of return");
            returned = Console.ReadLine();

            DateTime dueDate = DateTime.ParseExact(due,"MM/dd/yyyy",null);
            DateTime returnedDate = DateTime.ParseExact(returned, "MM/dd/yyyy", null);
            
            Book bookObj = new Book(title,author,numOfPages,dueDate,returnedDate);

            Console.WriteLine("Enter days to read");
            bookObj.DaysToRead = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter daily late fee");
            bookObj.DailyLateFee = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Average pages per day: "+bookObj.AveragePagesReadPerDay());
            Console.WriteLine("Late Fee: "+bookObj.CalculateLateFee());
            

        }
    }
}
