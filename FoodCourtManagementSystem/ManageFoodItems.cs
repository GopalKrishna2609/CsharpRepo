using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem
{
    internal class ManageFoodItems : Reports
    { 
        string FoodItemName, FoodCategory;
        int FoodItemPrize , FoodItemID;

        public void Options()
        {
            Console.WriteLine("---------------WELCOME TO ADMIN PORTAL---------------");
            Console.WriteLine("");
            Console.WriteLine("Please chooes one of the following action:");
            Console.WriteLine("a. Add a Food Item to the Menue .");
            Console.WriteLine("b. Show the Menue.");
            Console.WriteLine("c. Edit the Menue .");

            char choice1 = Convert.ToChar(Console.ReadLine());
            switch (choice1)
            {
                case 'a':
                    Console.WriteLine("");
                    AddFoodItemToMenue();
                    break;

                case 'b':
                    Console.WriteLine("");
                    ShowMenue();
                    break;

                case 'c':
                    Console.WriteLine("");
                    EditMenue();
                    Console.ReadLine();

                    break;

            }
        }
        public void AddFoodItemToMenue()
        {
           

            Random rnd = new Random();
            FoodItemID = rnd.Next(0, int.MaxValue);

            FileStream fileStreamObj = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\FoodItemsDetails.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);

            int counter = 1, totalItems;
            Console.WriteLine("Enter total number Of Food Items you want to Add to  the Menue");
            totalItems = Convert.ToInt32(Console.ReadLine());


            while (counter <= totalItems)
            {
                
                Console.WriteLine("FoodItem ID : ");
                Console.WriteLine(FoodItemID = rnd.Next(0, int.MaxValue));
                streamWriterObj.Write(FoodItemID + ",");

                Console.WriteLine("Enter Food Item Name :");
                FoodItemName = Console.ReadLine();
                streamWriterObj.Write(FoodItemName + ",");

                Console.WriteLine("Enter Food Item Prize :");
                FoodItemPrize = Convert.ToInt32(Console.ReadLine());
                streamWriterObj.Write(FoodItemPrize + ",");

                Console.WriteLine("Enter Food Item Category :");
                FoodCategory = Console.ReadLine();
                streamWriterObj.Write(FoodCategory + ",\n");

                counter++;
               
            }
            streamWriterObj.Close();
            fileStreamObj.Close();
            Console.WriteLine("File write operation completed");
            Console.ReadLine();
        }
        public void ShowMenue()
        {

            try
            {
                if (!File.Exists(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\FoodItemsDetails.txt"))
                {
                    Console.WriteLine("No Food Items yet");

                }
                else
                {

                    FileStream fileStreamObj = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\FoodItemsDetails.txt", FileMode.Open,FileAccess.Read);
                    StreamReader streamReaderObj = new StreamReader(fileStreamObj);
                    //Display the food item code
                    Console.WriteLine("FoodItemId\t\tFoodItemName\tPrize\t\tCategory");
                    while (streamReaderObj.Peek() > 0)
                    {
                        string line = streamReaderObj.ReadLine();
                        string[] FoodItemArr = line.Split(',');

                        for (int i = 0; i < FoodItemArr.Length; i++)
                        {
                            Console.Write(FoodItemArr[i] + "\t\t");
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
        public void EditMenue()
        {
            Console.WriteLine("Please chooes one of the following action:");
            Console.WriteLine("a. Remove Any Food Item.");
            Console.WriteLine("b. Change Prize of Food Item.");
            char choice1 = Convert.ToChar(Console.ReadLine());
            switch (choice1)
            {
                case 'a':

                    try
                    {
                        if (!File.Exists(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\FoodItemsDetails.txt"))
                        {
                            Console.WriteLine("No Food Items yet");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.Write("Enter Food Item to be removed from the menu - ");
                            string ans = Console.ReadLine();
                            FileStream fileStreamObj1 = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\FoodItemsDetails.txt", FileMode.Open);
                            StreamReader StreamReaderObj1 = new StreamReader(fileStreamObj1);
                            FileStream fileStreamObj2 = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\FoodItemsDetails1.txt", FileMode.Create, FileAccess.Write);
                            StreamWriter streamWriterObj2 = new StreamWriter(fileStreamObj2);
                            while (StreamReaderObj1.Peek() > 0)
                            {
                                string line = StreamReaderObj1.ReadLine();
                                if (!line.Contains(ans))
                                {
                                    streamWriterObj2.WriteLine(line);
                                }
                            }
                            StreamReaderObj1.Dispose();
                            StreamReaderObj1.Close();
                            fileStreamObj1.Close();
                            streamWriterObj2.Dispose();
                            streamWriterObj2.Close();
                            fileStreamObj2.Close();
                            File.Delete(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\FoodItemsDetails.txt");
                            File.Move(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\FoodItemsDetails1.txt", @"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\FoodItemsDetails.txt");
                            Console.WriteLine("The Food Item Is been REMOVED");
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
                    break;

                case 'b':

                    try
                    {
                        if (!File.Exists(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\FoodItemsDetails.txt"))
                        {
                            Console.WriteLine("No Food Items yet");
                        }
                        else
                        {


                            Console.WriteLine("");
                            Console.Write("Enter The Food Item whose prize is to be changed - ");
                            string ans1 = Console.ReadLine();
                            FileStream fileStreamObj3 = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\FoodItemsDetails.txt", FileMode.Append, FileAccess.Write);
                            StreamWriter StreamWriterObj3 = new StreamWriter(fileStreamObj3);
                            File.Move(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\FoodItemsDetails.txt", @"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\FoodItemsDetails1.txt");

                            FileStream fileStreamObj4 = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\FoodItemsDetails1.txt", FileMode.Open, FileAccess.Read);

                            StreamReader streamReaderObj4 = new StreamReader(fileStreamObj4);
                            while (streamReaderObj4.Peek() > 0)
                            {
                                string line = streamReaderObj4.ReadLine();



                                if (line.Contains(ans1))
                                {
                                    Console.WriteLine("Enter the New prize -");
                                    this.FoodItemPrize = Convert.ToInt32(Console.ReadLine());

                                    StreamWriterObj3.Write(line.Contains(Convert.ToString( this.FoodItemPrize)));
                                }
                                else
                                    Console.WriteLine("Item Not Found");

                            }

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
                    break;

            }
        }
    }
}

