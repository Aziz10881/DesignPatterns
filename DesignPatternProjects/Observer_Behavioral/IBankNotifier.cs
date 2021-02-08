using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Behavioral
{
    interface IBankNotifier
    {
        void Subscribe(Observer observer);
        void UnSubscribe(Observer observer);
        void Notify();
    }
}
