using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace Library_ADO
{
    internal class Book
    {
        public static string sqlConnectionStr = @"Data Source=DESKTOP-CEIJQT1;Initial Catalog=Library;Integrated Security=True";

        public string InsertBook()
        {
            Console.Write("Enter Book Id:- ");
            int BookID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book name:- ");
            string BookName = Console.ReadLine();

            Console.Write("Enter the Book Author:-");
            string BookAuthor = Console.ReadLine();

            Console.Write("Enter the Book Publication:-");
            string BookPublication = Console.ReadLine();


            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into Book values(" + BookID + ",'" + BookName + "','" + BookAuthor + "','" + BookPublication + "')", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Inserted";
            return "Inserted";


        }
        public string UpdateBook()
        {
            Console.Write("Enter Book Id:- ");
            int BookID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Book name:- ");
            string BookName = Console.ReadLine();

            Console.Write("Enter the Book Author:-");
            string BookAuthor = Console.ReadLine();

            Console.Write("Enter the Book Publication:-");
            string BookPublication = Console.ReadLine();

            //insert customer data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("update Customer set BookName='" + BookName + "' , BookAuthor='" + BookAuthor + "' , BookPublication=" + BookPublication + "' where BookID=" + BookID + "", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Updated";
            return "Updated";
        }

        public string DeleteBook(int BookID)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("DELETE from Customer where ID = " + BookID, sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Deleted";
            return "Deleted";
        }

        public DataTable SelectBook()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("SELECT * from Book", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close(); //connection state is close
            return dataTable;
        }

        public DataTable SelectBookID()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("SELECT * from Book", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close(); //connection state is close
            return dataTable;
        }
    }
}