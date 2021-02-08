using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Behavioral
{
    public class Observer:IObserver
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool HasApp { get; set; }

        public Observer(string firstName, string lastName, bool hasApp)
        {
            FirstName = firstName;
            LastName = lastName;
            HasApp = hasApp;
        }

        public void Update(BankApplication bankApplication)
        {
            if (HasApp == false)
            {
                Console.WriteLine("{0} {1}, We have developed a mobile app where you can control all your accounts, ", FirstName, LastName);
                Console.WriteLine("loans and use our services online with a few clicks.");
                Console.WriteLine("Please consider installing our app");
                Console.WriteLine("To install the app search the name of our bank in App store or Play store");
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("{0} {1}, Please consider rating our app in Play Store or App Store", FirstName, LastName);
                Console.WriteLine("\n");
            }
        }
    }
}
