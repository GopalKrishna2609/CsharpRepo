using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem
{
    internal class ManageFoodCategory : Reports
    {
        int CatID;
        string CatName;
        public void Options()
        {
            Console.WriteLine("---------------WELCOME TO CATEGORY PORTAL---------------");
            Console.WriteLine("");
            Console.WriteLine("Please chooes one of the following action:");
            Console.WriteLine("a. Add a New Category");
            Console.WriteLine("b. Show All the Category Details");
            Console.WriteLine("c. Edit Category Details");    
 
            char choice1 = Convert.ToChar(Console.ReadLine());
            switch (choice1)
            {
                case 'a':
                    break;
                    case 'b':
                    break;
            }
        }
        public void AddFoodItemToMenue()
        {
          

            FileStream fileStreamObj = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\CategoryDetails.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);

            int counter = 1, total;
            Console.WriteLine("Enter total number Of Categories you want to Add to  the Menue");
            total = Convert.ToInt32(Console.ReadLine());


            while (counter <= total)
            {
                Console.WriteLine("Enter Food Item Prize :");
                CatID = Convert.ToInt32(Console.ReadLine());
                streamWriterObj.Write(CatID + ",");

                Console.WriteLine("Enter Food Item Name :");
                CatName = Console.ReadLine();
                streamWriterObj.Write(CatName + ",");

                counter++;

            }
            streamWriterObj.Close();
            fileStreamObj.Close();
            Console.WriteLine("File write operation completed");
            Console.ReadLine();
        }
        public void ShowCatDetails()
        {

            try
            {
                if (!File.Exists(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\CategoryDetails.txt"))
                {
                    Console.WriteLine("No Categoties Found yet");

                }
                else
                {

                    FileStream fileStreamObj = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\CategoryDetails.txt", FileMode.Open, FileAccess.Read);
                    StreamReader streamReaderObj = new StreamReader(fileStreamObj);
                    //Display the food item code
                    Console.WriteLine("CategoryID\t\tCategoryName");
                    while (streamReaderObj.Peek() > 0)
                    {
                        string line = streamReaderObj.ReadLine();
                        string[] order = line.Split(',');

                        for (int i = 0; i < order.Length; i++)
                        {
                            Console.Write(order[i] + "\t\t");
                            if (i == 1)
                            {
                                Console.Write("");
                            }
                        }

                        Console.WriteLine("\n");
                    }

                    streamReaderObj.Close();
                    fileStreamObj.Close();
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR 404");
                using (FileStream fileStreamObj2 = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\MovieTicketBookingSystem\Log.txt", FileMode.Create, FileAccess.Write))
                {
                    StreamWriter streamWriterObj = new StreamWriter(fileStreamObj2);
                    streamWriterObj.Write("Date : " + DateTime.Now.ToString() + " ");
                    streamWriterObj.Write("Message : " + ex.Message + " ");
                    streamWriterObj.WriteLine("StackTrace : " + ex.StackTrace + " ");


                }
            }
        }
    }
}
