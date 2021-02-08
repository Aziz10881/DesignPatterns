using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Structural
{
    interface IDeposit
    {
        void DepositInUSD();
        void DepositInUZS();
    }
}
