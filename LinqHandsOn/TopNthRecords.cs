using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandsOn
{
    internal class TopNthRecords
    {
        public void FindTopNthRecord()
        {
            Console.Write("Enter the Number of Integers you want to enter :");
            int Num = Convert.ToInt32(Console.ReadLine());
            List<int> NumList = new List<int>();
            for (int i = 1; i <= Num; i++)
            {
                Console.Write((i) + ". Enter Number ");
                NumList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("\nThe members of the list are : ");
            foreach (int i in NumList)
            {
                Console.WriteLine(i);
            }
            Console.Write("How many records you want to display ? : ");
            int n = Convert.ToInt32(Console.ReadLine());

            NumList.Sort();
            NumList.Reverse();

            Console.Write("The top {0} records from the list are : \n", n);
            foreach (int topn in NumList.Take(n))
            {
                Console.WriteLine(topn);
            }
            Console.ReadLine();
        }
    }
}
