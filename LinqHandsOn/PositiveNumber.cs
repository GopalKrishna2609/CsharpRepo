using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqHandsOn
{
    internal class PositiveNumber
    {
        public void PositiveNum()
        {
            Console.Write("Enter the Number of Integers you want to enter :");
            int Num = Convert.ToInt32( Console.ReadLine());
            List<int> NumList = new List<int>();
            for (int i = 1; i <= Num; i++)
            {
                Console.Write((i) + ". Enter Number ");
                NumList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("List of numbers saved");
         
            //Linq Querry
            var positiveNumbers = NumList.Where(x => x > 0).ToList();
            

            Console.WriteLine("Positive Numbers through Linq Querry :");
            foreach (int numbers in positiveNumbers)
            {
                Console.WriteLine(numbers);
            }
            Console.ReadLine();
        }
    }
}
