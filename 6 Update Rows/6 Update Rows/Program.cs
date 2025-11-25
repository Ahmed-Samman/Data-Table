using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Update_Rows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Country", typeof(string));
            dt.Columns.Add("Salary", typeof(Double));
            dt.Columns.Add("Date", typeof(DateTime));

            dt.Rows.Add(1, "Mohamed Abu-Hadhoud", "Jordon", 5000, DateTime.Now);
            dt.Rows.Add(2, "Ahmed Samman", "Egypt", 525.5, DateTime.Now);
            dt.Rows.Add(3, "Fadi Ali", "USA", 730.5, DateTime.Now);
            dt.Rows.Add(4, "Gehad Farok", "London", 800, DateTime.Now);
            dt.Rows.Add(5, "Kamel Tamer", "Jordon", 7000, DateTime.Now);


            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t Date: {4} \t"
                   , row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

            //--------------------------------------------//


            DataRow[] ResultRow; // Note : This is Reference From Original DataTable Not Value

            // First You Filter For Row Id = 4
            ResultRow = dt.Select("ID = 4");

            foreach (DataRow Row in ResultRow)
            {
                Row["Name"] = "Maha Ahmed";
                Row["Salary"] = "900";
            }

            // This Using When I want to Accept Changes With DataBase
            //dt.AcceptChanges();

            Console.WriteLine("\n\nUpdating ID = 4 Record:");

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t Date: {4} \t"
                   , row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }



        }
    }
}
