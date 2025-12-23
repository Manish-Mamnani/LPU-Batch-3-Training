using System;
using System.Runtime.Serialization;

namespace CakeWorldDay5Assignment
{
    internal class InvalidFlavorException : Exception
    {
        string errorMessage;
        public InvalidFlavorException() : base()
        {
        }

        public InvalidFlavorException(string errorMessage) : base(errorMessage)
        {
        }

        public string ErrorMessage { get; set; }

    }
}