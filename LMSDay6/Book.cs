using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDay6
{
    internal class Book
    {
        #region Fields

        string title;
        string author;
        int numPages;
        DateTime dueDate;
        DateTime returnedDate;

        #endregion

        #region Properties

        public int DaysToRead {  get; set; }
        public int DailyLateFee {  get; set; }

        #endregion

        #region Constructors

        public Book() { }

        public Book(string title,string author,int numPages,DateTime dueDate,DateTime returnedDate)
        {
            this.title = title;
            this.author = author;
            this.numPages = numPages;
            this.dueDate = dueDate;
            this.returnedDate = returnedDate;
        }

        #endregion

        #region Methods

        public double AveragePagesReadPerDay()
        {
            return (double)numPages / DaysToRead;
        }

        public double CalculateLateFee()
        {
            int numberOfDaysLate = (dueDate - returnedDate).Days;
            if(numberOfDaysLate > 0)
            {
                return 0;
            }
            return (double)Math.Abs(numberOfDaysLate) * DailyLateFee;
        }

        #endregion


    }
}
