using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MiltiThreading
{
    internal class DisplayThread
    {

        public void ShowData(string s)
        {
            Console.WriteLine(s);
        }
        public void DisplayFood()
        {
            //data and functions here is executed parallerly not in a sequencial manner 
            List<string> foodCollections = new List<string>()
            {
                 "Pizza","Burger","French Fries","Pasta","Maggie"
            };
            Parallel.ForEach(foodCollections, food => ShowData(food));

            //execution of 2 function parallerly 
            Parallel.Invoke(ShowDealerReport, ShowBuyerReport);

        }


        public void ShowBuyerReport()
        {
            char buyerName = 'a';
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(buyerName++);

                //pauses for 100 mili second
                Thread.Sleep(100);
            }

        }

        public void ShowDealerReport()
        {
            int dealerNumber = 1;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(dealerNumber++);
                Thread.Sleep(100);
            }
        }


    }
}
