using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandsOn
{
    internal class FrequencyOfCharacter
    {
        public void Frequency()
        {
            Console.Write("Enter a String :");
            string str = Console.ReadLine();
            //Linq Querry
            var freq= from x in str
                      group x by x into y
                      select y;
            Console.WriteLine("\nThe number and the Frequency are :\n");
            foreach (var n in freq)
            {
                Console.WriteLine("Character " + n.Key + " appears " + n.Count() + " times");
            }
            Console.ReadLine();
        }
    }
}
