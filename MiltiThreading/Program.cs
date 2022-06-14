using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MiltiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayThread mt = new DisplayThread();
            Thread t1 = new Thread(mt.ShowBuyerReport);
            Thread t2 = new Thread(mt.ShowDealerReport);
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }

        
    }
    
}

