using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount CurrentObj = new CurrentAccount();
            string Name =CurrentObj.AccountName();
            int AccountNum = CurrentObj.AccountNumber();
            decimal AccountBal = CurrentObj.AccountBalance();
            string ATM = CurrentObj.ATM();
            Console.WriteLine("AccountName: " + Name);
            Console.WriteLine("AccountNumber: " + AccountNum);
            Console.WriteLine("AccountBalance: " + AccountBal);

            Console.WriteLine("ATM status: " + ATM);

            IAccount IObj = new IAccount();

            Console.ReadLine();
        }
    }
}
