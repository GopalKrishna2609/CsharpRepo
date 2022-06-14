using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace Library_ADO
{
    internal class Author
    {
        public static string sqlConnectionStr = @"Data Source=DESKTOP-CEIJQT1;Initial Catalog=Library;Integrated Security=True";

        public string InsertAuthor()
        {
            Console.Write("Enter Author Id:- ");
            int Author_ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Author name:- ");
            string Author_Name = Console.ReadLine();

            Console.Write("Enter the Auhtor's age:-");
            int Author_Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Author Phone:- ");
            int Author_Phone = Convert.ToInt32(Console.ReadLine());

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("insert into Author values(" + Author_ID + ",'" + Author_Name + "'," + Author_Age + "," + Author_Phone + ")", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Inserted";
            return "Inserted";

        }
        public string UpdateAuthor()
        {
            Console.Write("Enter Author Id:- ");
            int AuthorID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Author name:- ");
            string AuthorName = Console.ReadLine();

            Console.Write("Enter the Auhtor's age:-");
            int AuthorAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Author Phone:- ");
            int AuthorPhone = Convert.ToInt32(Console.ReadLine());

            //insert customer data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("update Author set AuthorName='" + AuthorName + "' , AuthorAge='" + AuthorAge + "' , AuthorPhone=" + AuthorPhone + "' where AuthorID=" + AuthorID + "", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Updated";
            return "Updated";
        }

        public string DeleteAuthor(int AuthorID)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("DELETE from Author where AuthorID = " + AuthorID, sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Deleted";
            return "Deleted";
        }

        public DataTable SelectAuthor()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("SELECT * from Author", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close(); //connection state is close
            return dataTable;
        }

        public DataTable SelectAuthorID()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("SELECT * from Author", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close(); //connection state is close
            return dataTable;
        }
    }
}