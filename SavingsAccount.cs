using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class SavingsAccount : Account
    {
        public override string AccountName()
        {
            return ("Megha");
        }
        public override int AccountNumber()
        {
            return (1122334455);
        }
        public override decimal AccountBalance()
        {
            return (12300);
        }
        public override string ATM() 
        {
            return ("ATM is avilable");
        }
    }
}
