using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() : base() {  }
        public InsufficientFundsException(string message) : base(message) { }
        public InsufficientFundsException(string message, Exception innerException)
            : base(message, innerException) { }

        public DateTime TransactionDate { get; set; }
        public double Amount { get; set; }
        public string CustomMessage
        {
            get { 
                return $"{Message} on {TransactionDate:dd-MMM-yyyy hh:mm:ss} for {Amount:C2}"; 
            }
        }

    }
}
