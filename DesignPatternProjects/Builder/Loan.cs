using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Loan
    {
        public string LoanType { get; set; }

        public int LoanLength { get; set; }

        public double LoanPercentage { get; set; }

        public double LoanAmount { get; set; }


        public void ShowInformation()
        {
            Console.WriteLine("Loan Type: {0}", LoanType);
            Console.WriteLine("Loan Length: {0} months", LoanLength);
            Console.WriteLine("Loan Interest rate: {0}%", LoanPercentage);
            Console.WriteLine("Loan Amount: {0} UZS", LoanAmount);
        }
    }
}
