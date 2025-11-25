using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _9_Autoincrement_and_Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();

            //dt.Columns.Add("ID", typeof(int));
            //dt.Columns.Add("Name", typeof(string));
            //dt.Columns.Add("Country", typeof(string));
            //dt.Columns.Add("Salary", typeof(Double));
            //dt.Columns.Add("Date", typeof(DateTime));

            // First Column 
            DataColumn dtColumn = new DataColumn();
            dtColumn.ColumnName = "ID";
            dtColumn.DataType = typeof(int);
            dtColumn.AutoIncrement = true;
            dtColumn.AutoIncrementSeed = 1;
            dtColumn.AutoIncrementStep = 1;

            dtColumn.Caption = "Employee ID"; // Ilias (Nick Name)
            dtColumn.ReadOnly = true;
            dtColumn.Unique = true;
            dt.Columns.Add(dtColumn);

            // Second Column
            dtColumn = new DataColumn();
            dtColumn.ColumnName = "Name";
            dtColumn.DataType = typeof(string);
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Name";
            dtColumn.ReadOnly= false;
            dtColumn.Unique= false;
            dt.Columns.Add(dtColumn);

            // Third Column
            dtColumn = new DataColumn();
            dtColumn.ColumnName = "Country";
            dtColumn.DataType= typeof(string);
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Country";
            dtColumn.ReadOnly = false;
            dtColumn.Unique= false;
            dt.Columns.Add(dtColumn);

            // Fourth Column
            dtColumn = new DataColumn();
            dtColumn.ColumnName = "Salary";
            dtColumn.DataType = typeof(Double);
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Country";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            dt.Columns.Add(dtColumn);

            // Fifth Column
            dtColumn = new DataColumn();
            dtColumn.ColumnName = "Date";
            dtColumn.DataType = typeof(DateTime);
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Date";
            dtColumn.ReadOnly = false;
            dtColumn.Unique= false;
            dt.Columns.Add(dtColumn);

            // Add Data in Columns
            dt.Rows.Add(null, "Mohamed Abu-Hadhoud", "Jordon", 5000, DateTime.Now);
            dt.Rows.Add(null, "Ahmed Samman", "Egypt", 525.5, DateTime.Now);
            dt.Rows.Add(null, "Fadi Ali", "USA", 730.5, DateTime.Now);
            dt.Rows.Add(null, "Gehad Farok", "London", 800, DateTime.Now);
            dt.Rows.Add(null, "Kamel Tamer", "Jordon", 7000, DateTime.Now);


            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t Date: {4} \t"
                   , row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);
            }




        }

    }
}
