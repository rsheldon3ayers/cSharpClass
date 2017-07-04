using System;
namespace Assignment6
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        : base("Invalid Entry – Negative numbers are not permitted.")
        {

        }
        public NegativeNumberException(string message)
        : base(message)
        {

        }
        public NegativeNumberException(string message, Exception inner)
        : base(message, inner)
        {

        }
    }
}
