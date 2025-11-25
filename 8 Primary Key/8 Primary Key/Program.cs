using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Primary_Key
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

            // Add Primery Key
            DataColumn[] PrimaryKeyColumn = new DataColumn[1];
            PrimaryKeyColumn[0] = dt.Columns["ID"];
            //PrimaryKeyColumn[1] = dt.Columns["Name"]; //If i want do Composite Primary Key
            dt.PrimaryKey = PrimaryKeyColumn;

            // OR

            dt.PrimaryKey = new DataColumn[] { dt.Columns["ID"] };
            // dt.PrimaryKey = new DataColumn[1] { dt.Columns["Name"] }; //If i want do Composite Primary Key


            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t Date: {4} \t"
                   , row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }

        }
    }
}
