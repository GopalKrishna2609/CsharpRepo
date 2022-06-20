using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManageFoodItems manageFoodItems = new ManageFoodItems();
            ManageFoodCategory manageFoodCategory = new ManageFoodCategory();
            ManageSales manageSales = new ManageSales();
            Console.WriteLine("Press 1 : To Manage Food Items");
            Console.WriteLine("Press 2 : To Manage the Category ");
            Console.WriteLine("Press 3 : To Manage the sales");
            Console.WriteLine("Press 4 : To See Reports");
            int Choise = Convert.ToInt32(Console.ReadLine());
            switch(Choise)
            {
                case 1:
                    manageFoodItems.Options();
                    break;
                    case 2:
                    manageFoodCategory.Options();
                    break ;
                    case 3:
                    manageSales.Options();
                    break;
                default:
                    Console.WriteLine("Incorrect Input Try Again");
                    break;
            }
           
                     
                        
                }
            }
    }

