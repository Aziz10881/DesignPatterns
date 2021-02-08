using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class LoanForIndividuals : ILoanBuilder
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
            
            if (objLoan.LoanAmount >= 60000000 && objLoan.LoanAmount <= 90000000)
            {
                objLoan.LoanLength = 36;
            }
            else if (objLoan.LoanAmount >= 30000000 && objLoan.LoanAmount < 60000000)
            {
                objLoan.LoanLength = 24;
            }
            else if (objLoan.LoanAmount > 90000000)
            {
                objLoan.LoanLength = 60;
            }          
            else
            {
                objLoan.LoanLength = 12;
            }
        }

        public void SetLoanPercentage()
        {
            if(objLoan.LoanType == "differential")
            {
                objLoan.LoanPercentage = 11;
            }
            else
            {
                objLoan.LoanPercentage = 10;
            }
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
                Console.WriteLine("please enter one of these symbols: '1', '2' ");
                SetLoanType();
            }

        }
    }
}
