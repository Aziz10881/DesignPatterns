using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Behavioral
{
    public class BankApplication:IBankNotifier
    {
        public string AppName { get; set; }

        public string AppVersion { get; set; }

        public BankApplication(string appName, string appVersion)
        {
            AppName = appName;
            AppVersion = appVersion;
        }

        List<Observer> observers = new List<Observer>();

        public void Notify()
        {
            foreach(Observer observer1 in observers)
            {
                observer1.Update(this);
            }

        }

        public void Subscribe(Observer observer)
        {
            observers.Add(observer);
        }

        public void UnSubscribe(Observer observer)
        {
            observers.Add(observer);
        }
    }
}
