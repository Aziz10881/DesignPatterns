using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            GetLoaner();
            Console.ReadLine();
        }

        public static void GetLoaner()
        {
            Console.WriteLine("If you are an individual type '1', if you are a legal entity type '2', if you are a student type '3' and press 'Enter'");
            string input = Console.ReadLine();
            if (input == "1")
            {
                var loanDirector = new LoanDirector(new LoanForIndividuals());
                loanDirector.SetLoan();

                var loan = loanDirector.GetLoan();
                loan.ShowInformation();
            }
            else if (input == "2")
            {
                var loanDirector = new LoanDirector(new LoanForLegalEntities());
                loanDirector.SetLoan();

                var loan = loanDirector.GetLoan();
                loan.ShowInformation();
            }
            else if (input == "3")
            {
                var loanDirector = new LoanDirector(new LoanForStudents());
                loanDirector.SetLoan();

                var loan = loanDirector.GetLoan();
                loan.ShowInformation();
            }
            else
            {
                Console.WriteLine("please enter one of these numbers: '1', '2', '3'");
                GetLoaner();
            }
        }
    }
}
