using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandsOn
{
    internal class Program
    {
        public static void Options()
        {
            Console.WriteLine("\tWECOME TO LINQ QUERRY PROGRAMS");
            Console.WriteLine("Please Select Any one Option :");
            Console.WriteLine("Press 1 To Find Positive Numbers ");
            Console.WriteLine("Press 2 To Frequency Of Numbers ");
            Console.WriteLine("Press 3 To Find Frequency Of Characters ");
            Console.WriteLine("Press 4 To Find the string which starts and ends with a specific character ");
            Console.WriteLine("Press 5 To Find the Top N'th Record ");
            Console.WriteLine("Press 6 To Find the N-th Maximum grade point");
            Console.WriteLine("Press 7 To Find the Last Name Starts With");
            Console.WriteLine("Press 8 To Find the words in the collection that start with the letter 'L'");
            Console.WriteLine("Press 9 To Find the numbers are multiples of 4 or 6");

            Console.WriteLine("Press 0 to Exit");
        }
        static void Main(string[] args)
        {
        mainOptios:
            Options();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("-------------------------LINQ Querry To Find Positive Numbers-------------------------");
                    PositiveNumber linqQuerry = new PositiveNumber();
                    linqQuerry.PositiveNum();
                    goto mainOptios;
                   
                case 2:
                    Console.WriteLine("-------------------------LINQ Querry To Find Frequency Of Numbers-------------------------");
                    FrequencyOfNumber frequencyOfNumber = new FrequencyOfNumber();
                    frequencyOfNumber.Frequency();
                    goto mainOptios;
                   
                case 3:
                    Console.WriteLine("-------------------------LINQ Querry To Find Frequency Of Characters-------------------------");
                    FrequencyOfCharacter frequencyOfCharacter = new FrequencyOfCharacter();
                    frequencyOfCharacter.Frequency();
                    goto mainOptios;
                   
                case 4:
                    Console.WriteLine("--------------------LINQ Querry To Find the string which starts and ends with a specific character--------------------");
                    StartAndEndsWithSpecificCharacter startAndEndsWithSpecificCharacter = new StartAndEndsWithSpecificCharacter();
                    startAndEndsWithSpecificCharacter.Function();
                    goto mainOptios;
                    
                case 5:
                    Console.WriteLine("-------------------------LINQ Querry To Find the Top N'th Record-------------------------");
                    TopNthRecords topNthRecords = new TopNthRecords();
                    topNthRecords.FindTopNthRecord();
                    goto mainOptios;
                case 6:
                    Console.WriteLine("-------------------------LINQ Querry To Find the N-th Maximum grade point -------------------------");
                    Students students = new Students();
                    students.NthMaximumGradePoint();
                    goto mainOptios;
                    
                case 7:
                    Console.WriteLine("-------------------------LINQ Querry To Find the Last Name Starts With  -------------------------");
                    PresonLastName presonLastName = new PresonLastName();
                    presonLastName.LastNameWithD();
                    goto mainOptios;
                case 8:
                    Console.WriteLine("-------------------LINQ Querry To Find the words in the collection that start with the letter 'L'-------------------");
                    CollectionStartsWith collectionStartsWith = new CollectionStartsWith();
                    collectionStartsWith.CollectionWithL();
                    goto mainOptios;
                case 9:
                    Console.WriteLine("-------------------LINQ Querry To Find the numbers Which are Multiples of 4 or 6-------------------");
                    MultipleOf multipleOf = new MultipleOf();
                    multipleOf.MultipleOf4_6();
                    goto mainOptios;
                default:
                    Console.WriteLine("SORRY WRONG ENTRY");
                    break;

            }
            }
        }
          
        
}
