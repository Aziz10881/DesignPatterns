using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   public class LoanDirector
    {
        private readonly ILoanBuilder objBuilder;

        public LoanDirector(ILoanBuilder builder)
        {
            objBuilder = builder;
        }

        public void SetLoan()
        {
            objBuilder.SetLoanType();
            objBuilder.SetLoanAmount();
            objBuilder.SetLoanPercentage();
            objBuilder.SetLoanLength();
        }

        public Loan GetLoan()
        {
            return objBuilder.GetLoan();
        }
    }
}
