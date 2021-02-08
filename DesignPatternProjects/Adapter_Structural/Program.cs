using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Structural
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCurrency();

            Console.ReadLine();
        }

        public static void GetCurrency()
        {
            Console.WriteLine("Please choose the currency of your deposit");
            Console.WriteLine("Type '1' for USD or '2' for UZS, then press 'Enter'");
            string input = Console.ReadLine();
            if(input == "1")
            {
                IDeposit deposit = new DepositCurrencyAdapter();

                deposit.DepositInUSD();
            }
            else if (input == "2")
            {
                IDeposit deposit = new DepositCurrencyAdapter();

                deposit.DepositInUZS();
            }
            else
            {
                Console.WriteLine("please enter one of these numbers: '1', '2'");
                GetCurrency();
            }
        }
    }
}
