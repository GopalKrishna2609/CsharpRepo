using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandsOn
{
    internal class FrequencyOfNumber
    {
        public void Frequency()
        {
            Console.Write("Enter the Number of Integers you want to enter :");
            int Num = Convert.ToInt32(Console.ReadLine());
            List<int> NumList = new List<int>();
            for (int i = 1; i <= Num; i++)
            {
                Console.Write((i) + ". Enter Number ");
                NumList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("List of numbers saved");
            //Linq Querry
            var num = from x in NumList
                      group x by x into y
                      select y;
            Console.WriteLine("\nThe number and the Frequency are :\n");
            foreach (var n in num)
            {
                Console.WriteLine("Number " + n.Key + " appears " + n.Count() + " times");
            }
            Console.ReadLine();
        }
    }
}
