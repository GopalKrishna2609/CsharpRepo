using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandsOn
{
    internal class CollectionStartsWith
    {
        public void CollectionWithL()
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            var outputList = (from froutList in fruits
                              where froutList.StartsWith("L")
                              select froutList).ToList();
            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("words in the collection that start with the letter 'L'");
            foreach (var resultitem in outputList)
            {
                Console.Write($"{resultitem}, ");
            }
            Console.WriteLine("");

        }
    }
}
