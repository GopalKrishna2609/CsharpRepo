using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandsOn
{
    internal class StartAndEndsWithSpecificCharacter
    {
        public void Function()
        {
            Console.Write("Enter the Number of Cities you want to enter :");
            int Num = Convert.ToInt32(Console.ReadLine());
            List<string> CityList = new List<string>();
            for (int i = 1; i <= Num; i++)
            {
                Console.Write((i) + ". Enter City Name ");
                CityList.Add(Console.ReadLine());
            }
            Console.WriteLine("List of Cities Are :");
            foreach (string str in CityList)
            {
                Console.WriteLine(str);
            }

            Console.Write("\nInput starting character for the string : ");
            string chStart = Console.ReadLine();
            Console.Write("\nInput ending character for the string : ");
            string chEnd = Console.ReadLine();


            //Linq Querry
            var result  = from x in CityList
                          where x.StartsWith(chStart)
                          where x.EndsWith(chEnd)
                          select x;

            foreach (string str in result)
            {
                Console.Write("The city starting with {0} and ending with {1} is : {2} \n", chStart, chEnd, str);
            }

            Console.ReadLine();
        }
    }
}
