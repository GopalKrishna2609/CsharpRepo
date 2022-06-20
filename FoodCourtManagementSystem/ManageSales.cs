using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem
{
    internal class ManageSales : Reports
    {
        int salesid, noPlate, perplatecost;
        string saleitemname, cusname;
        long phoneNo;
        public void Options()
        {
            Console.WriteLine("---------------WELCOME TO SALES PORTAL---------------");
            Console.WriteLine("");
            Console.WriteLine("Please chooes one of the following action:");
            Console.WriteLine("a. Add Order .");
            Console.WriteLine("b. Show Order History");
            char choice1 = Convert.ToChar(Console.ReadLine());
            switch (choice1)
            {
                case 'a':
                    add:
                    AddOrder();
                    Console.WriteLine("If you want to add Another Order press 1");
                    int x = Convert.ToInt32(Console.ReadLine());
                    if (x == 1)
                        goto add;
                    break;
                case 'b':
                    ShowOrderHistory();
                    break;
            }
        }
        public void AddOrder()
        {

            FileStream fileStreamObj = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\SalesDetails.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);

 
                Console.Write(" Enter the new sales id ");
                salesid = Convert.ToInt32(Console.ReadLine());
                streamWriterObj.Write(salesid + ",");

                Console.Write("Enter the New sales item name ");
                saleitemname = Console.ReadLine();
                streamWriterObj.Write(saleitemname + ",");

                Console.Write("Enter the Customer Name");
                cusname = Console.ReadLine();
                streamWriterObj.Write(cusname + ",");

                Console.Write("Enter customer Phone Number");
                phoneNo = Convert.ToInt32(Console.ReadLine());
                streamWriterObj.Write(phoneNo + ",");

                Console.Write("Enter the Number of Plates ");
                noPlate = Convert.ToInt32(Console.ReadLine());
                streamWriterObj.Write(noPlate + ",");

                Console.Write("Enter the cost As per Plate");
                perplatecost = Convert.ToInt32(Console.ReadLine());
                streamWriterObj.Write(perplatecost + ",");
  
            streamWriterObj.Close();
            fileStreamObj.Close();
            Console.WriteLine("File write operation completed");
            Console.ReadLine();
        }
        public void ShowOrderHistory()
        {

            try
            {
                if (!File.Exists(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\SalesDetails.txt"))
                {
                    Console.WriteLine("No Order History yet");

                }
                else
                {

                    FileStream fileStreamObj = new FileStream(@"C:\Users\hp\Documents\TrainningRepo\AssignmentRepo\FoodCourtManagementSystem\SalesDetails.txt", FileMode.Open, FileAccess.Read);
                    StreamReader streamReaderObj = new StreamReader(fileStreamObj);
                    //Display the food item code
                    Console.WriteLine("SalesID\t\tSaleItemName\tCustomerName\t\t PhoneNo\t\t NoOfPlates\t\t CostPerPlate");
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
