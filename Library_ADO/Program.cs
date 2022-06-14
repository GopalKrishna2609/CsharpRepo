using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
namespace Library_ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            Console.WriteLine("Please Select one of the Options :\n");
            Console.WriteLine("\t\tPress 1 For Book Data");
            Console.WriteLine("\t\tPress 2 For Author Data");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Book book = new Book();
                    Console.WriteLine("Please Select one of the Options :\n");
                    Console.WriteLine("\t\tPress a to Insert Data.");
                    Console.WriteLine("\t\tPress b to Update Data.");
                    Console.WriteLine("\t\tPress c to Delete Data.");
                    Console.WriteLine("\t\tPress d to Show All Book Table Data.");
                    Console.WriteLine("\t\tPress e to Show a Perticular Book Data.");
                    string choice1 = Console.ReadLine();
                    switch (choice1)
                    {
                        case "a":
                            string result = book.InsertBook();
                            Console.WriteLine(result);
                            break;
                        case "b":
                            result = book.UpdateBook();
                            Console.WriteLine(result);
                            break;
                        case "c":
                            Console.WriteLine("\nEnter The Customer ID to Delete :");
                            int CustID = Convert.ToInt32(Console.ReadLine());
                            result = book.DeleteBook(CustID);
                            Console.WriteLine(result);
                            break;
                        case "d":
                            Console.WriteLine();
                            dt = book.SelectBook();
                            if (dt.Rows.Count == 0)
                            {
                                Console.WriteLine("NO DATA FOUND");
                            }
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    Console.Write(dt.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            Console.ReadLine();
                            break;
                        case "e":
                            Console.WriteLine("Enter The Customer ID To See Its Details : ");
                            int SearchID = Convert.ToInt32(Console.ReadLine());
                            dt = book.SelectBookID();
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {

                                if ((int)dt.Rows[i][0] == SearchID)
                                {
                                    {
                                        for (int j = 0; j < dt.Columns.Count; j++)
                                        {

                                            Console.Write(dt.Rows[i][j] + "\t\t");
                                        }
                                    }
                                }
                                Console.WriteLine();
                            }
                            break;
                    }
                    break;

                case 2:
                    Author author = new Author();
                    
                    Console.WriteLine("Please Select one of the Options :\n");
                    Console.WriteLine("\t\tPress a to Insert Data.");
                    Console.WriteLine("\t\tPress b to Update Data.");
                    Console.WriteLine("\t\tPress c to Delete Data.");
                    Console.WriteLine("\t\tPress d to Show All Employee Table Data.");
                    Console.WriteLine("\t\tPress e to Show a Perticular Employee Data.");

                    string choice2 = Console.ReadLine();
                    switch (choice2)
                    {
                        case "a":
                            string result = author.InsertAuthor();
                            Console.WriteLine(result);
                            break;
                        case "b":
                            result = author.UpdateAuthor();
                            Console.WriteLine(result);
                            break;
                        case "c":
                            Console.WriteLine("\nEnter The Customer ID to Delete :");
                            int EmpID = Convert.ToInt32(Console.ReadLine());
                            result = author.DeleteAuthor(EmpID);
                            Console.WriteLine(result);
                            break;
                        case "d":
                            Console.WriteLine();
                            dt = author.SelectAuthor();
                            if (dt.Rows.Count == 0)
                            {
                                Console.WriteLine("NO DATA FOUND");
                            }
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    Console.Write(dt.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            Console.ReadLine();
                            break;
                        case "e":
                            Console.WriteLine("Enter The Customer ID To See Its Details : ");
                            int SearchID = Convert.ToInt32(Console.ReadLine());
                            dt = author.SelectAuthorID();
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                // int ID = (int)dt.Rows[i][0];
                                if ((int)dt.Rows[i][0] == SearchID)
                                {
                                    {
                                        for (int j = 0; j < dt.Columns.Count; j++)
                                        {

                                            Console.Write(dt.Rows[i][j] + "\t\t");
                                        }
                                    }
                                }
                                Console.WriteLine();
                            }
                            break;

                    }
                    break;
            }
          
            

            Console.ReadLine();
        }
    }
}
