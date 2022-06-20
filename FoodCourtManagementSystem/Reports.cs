using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem
{
    internal class Reports 
    {
        public void Options()
        {
            ManageFoodItems manageFoodItems = new ManageFoodItems();
            ManageSales manageSales = new ManageSales();
            ManageFoodCategory manageFoodCategory = new ManageFoodCategory();
            Console.WriteLine("---------------WELCOME TO REPORTS PORTAL---------------");
            Console.WriteLine("");
            Console.WriteLine("Please chooes one of the following action:");
            Console.WriteLine("a. See Food Items Report");
            Console.WriteLine("b. See Category Report");
            Console.WriteLine("c. See Sales Report");


            char choice1 = Convert.ToChar(Console.ReadLine());
            switch (choice1)
            {
                case 'a':
                    manageFoodItems.ShowMenue();
                    break;
                   
                    case 'b':
                    manageFoodCategory.ShowCatDetails();
                    break;
                    case 'c':
                    manageSales.ShowOrderHistory();
                    break;
            }
        }
    }
}
