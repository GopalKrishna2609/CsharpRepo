using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
        public interface IAccount
        {
            string AccontName();
            int AccountNumber();
            decimal AccountBalance();

        }
        interface IAccountTransaction
        {
            int Transaction();
        }
        public class SalaryAccount : IAccount, IAccountTransaction
        {
            public string AccontName()
            {
            return "Abhay";
            }

            public decimal AccountBalance()
            {
                return 20000;
            }

            public int AccountNumber()
            {
                return 104323;
            }

            int Transaction()
            {
                return 2340;
            }

            int IAccountTransaction.Transaction()
            {
                return 2340;
            }
        }
    
}
