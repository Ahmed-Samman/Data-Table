using System;
using System.Linq;
using System.Data;


namespace _1_Create_Offline_Data_Table_and_ListData
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
            dt.Columns.Add("Date", typeof (DateTime));

            dt.Rows.Add(1, "Mohamed Abu-Hadhoud", "Jordon", 5000, DateTime.Now);
            dt.Rows.Add(2, "Ahmed Samman", "Egypt", 525.5, DateTime.Now);
            dt.Rows.Add(3, "Fadi Ali", "USA", 730.5, DateTime.Now);
            dt.Rows.Add(4, "Gehad Farok", "London", 800, DateTime.Now);
            dt.Rows.Add(5, "Kamel Tamer", "Oman", 7000, DateTime.Now);

   

            foreach (DataRow row in dt.Rows) 
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t Date: {4} \t"
                    , row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);


                // This is not prefare
               // Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t Date: {4} \t"
                 //  , row[0], row[1], row[2], row[3], row[4]);
            }
        }
    }
}
