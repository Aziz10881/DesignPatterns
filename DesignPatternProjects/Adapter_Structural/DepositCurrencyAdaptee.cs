using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Structural
{
    public class DepositCurrencyAdaptee
    {
        public double InterestRate;

       

        int amount = 0;
        int length = 0;
        public void MakeDepositInUSD()
        {
            Console.Write("Please enter the amount of deposit in USD: ");
            length = 36;
            amount = Convert.ToInt32(Console.ReadLine());
            if(amount < 1000)
            {
                Console.WriteLine("The minimum amount of deposit in USD is $1000");
                MakeDepositInUSD();
            }
            InterestRate = 12.5;
            Console.WriteLine("Deposit made: ${0} ", amount);
            Console.WriteLine("Length of the deposit: {0} months", length);
            Console.WriteLine("Interest rate: {0}% a year", InterestRate);
        }

        public void MakeDepositInUZS()
        {
            
            Console.Write("Please enter the amount of deposit in Uzbek sums: ");
            length = 24;
            amount = Convert.ToInt32(Console.ReadLine());
            if (amount < 5000000)
            {
                Console.WriteLine("The minimum amount of deposit in UZS is 5000000 soms");
                MakeDepositInUSD();
            }
            InterestRate = 16.5;
            Console.WriteLine("Deposit made: {0} soms", amount);
            Console.WriteLine("Length of the deposit: {0} months", length);
            Console.WriteLine("Interest rate: {0}% a year", InterestRate);

        }
    }
}
