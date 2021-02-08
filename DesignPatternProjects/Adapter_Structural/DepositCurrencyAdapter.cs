using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Structural
{
    public class DepositCurrencyAdapter : IDeposit
    {
        
        DepositCurrencyAdaptee adaptee = new DepositCurrencyAdaptee();

        public void DepositInUSD()
        {
            adaptee.MakeDepositInUSD();
        }

        public void DepositInUZS()
        {
            adaptee.MakeDepositInUZS();
        }
    }
}
