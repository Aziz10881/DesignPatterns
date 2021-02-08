using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Behavioral
{
    class Program
    {
        static void Main(string[] args)
        {
            BankApplication app = new BankApplication("CurrentBank", "1.0");
            Observer observer = new Observer("Aziz", "Norboev", false);
            Observer observer1 = new Observer("Keanuu", "Reeves", true);

            app.Subscribe(observer);
            app.Subscribe(observer1);
            app.Notify();

            Console.ReadLine();
        }
    }
}
