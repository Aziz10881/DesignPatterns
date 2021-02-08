using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Behavioral
{
    interface IObserver
    {
        void Update(BankApplication bankApplication);
    }
}
