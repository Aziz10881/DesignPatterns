using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class LoanForStudents : ILoanBuilder
    {
        Loan objLoan = new Loan();

        public Loan GetLoan()
        {
            return objLoan;
        }

        public void SetLoanAmount()
        {
            Console.Write("Please enter the loan amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            objLoan.LoanAmount = amount;
        }

        public void SetLoanLength()
        {
            if (objLoan.LoanAmount >= 60000000 && objLoan.LoanAmount <= 80000000)
            {
                objLoan.LoanLength = 60;
            }
            else if (objLoan.LoanAmount >= 40000000 && objLoan.LoanAmount < 60000000)
            {
                objLoan.LoanLength = 48;
            }
            else if (objLoan.LoanAmount > 80000000)
            {
                objLoan.LoanLength = 72;
            }
            else
            {
                objLoan.LoanLength = 36;
            }
        }

        public void SetLoanPercentage()
        {
            if (objLoan.LoanType == "differential")
            {
                objLoan.LoanPercentage = 8;
            }
            else
            {
                objLoan.LoanPercentage = 7;
            };
        }

        public void SetLoanType()
        {
            Console.WriteLine("Select Loan type, type '1' for 'Differential' or '2' for 'Annuity', then press 'Enter'");
            string type = Console.ReadLine();
            if (type == "1")
            {
                objLoan.LoanType = "Differential";
            }
            else if (type == "2")
            {
                objLoan.LoanType = "Annuity";
            }
            else
            {
                Console.WriteLine("please enter one of these symbols: 1, 2");
                SetLoanType();
            }
        }
    }
}
