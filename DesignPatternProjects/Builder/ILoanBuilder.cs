using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ILoanBuilder
    {
        void SetLoanType();
        void SetLoanLength();
        void SetLoanPercentage();
        void SetLoanAmount();

        Loan GetLoan();
    }
}
