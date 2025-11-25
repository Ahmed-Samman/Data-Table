using System;
using System.Linq;
using System.Data;


namespace _3_Filter_Data
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

            int Count = 0;
            double TotalSalaries = 0;
            double AvgSalaries = 0;
            double MinSalary = 0;
            double MaxSalary = 0;


            Count = dt.Rows.Count;
            TotalSalaries = Convert.ToDouble(dt.Compute("SUM(Salary)", string.Empty));
            AvgSalaries = Convert.ToDouble(dt.Compute("AVG(Salary)", string.Empty));
            MinSalary = Convert.ToDouble(dt.Compute("MIN(Salary)", string.Empty));
            MaxSalary = Convert.ToDouble(dt.Compute("Max(Salary)", string.Empty));


            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t Date: {4} \t"
                    , row["ID"], row["Name"], row["Country"], row["Salary"], row["Date"]);


                // This is not prefare
                // Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t Date: {4} \t"
                //  , row[0], row[1], row[2], row[3], row[4]);
            }


            Console.WriteLine("\nCount : " + Count);
            Console.WriteLine("Total Salaries : " + TotalSalaries);
            Console.WriteLine("Avg Salaries : " + AvgSalaries);
            Console.WriteLine("Min Salary : " + MinSalary);
            Console.WriteLine("Max Salary : " + MaxSalary);
            Console.WriteLine("//---------------------------------------------------------------------------------//");
            
//-----------------------------------------------------------------------------//

            // Filter 1 By Country Jordon

            int ResultCount = 0;
            DataRow[] ResultRows; // Note : This is Reference From Original DataTable Not Value

            ResultRows = dt.Select("Country = 'Jordon'");

            ResultCount = ResultRows.Count();
            TotalSalaries = Convert.ToDouble(dt.Compute("SUM(Salary)", "Country = 'Jordon'"));
            AvgSalaries = Convert.ToDouble(dt.Compute("AVG(Salary)", "Country = 'Jordon'"));
            MinSalary = Convert.ToDouble(dt.Compute("MIN(Salary)", "Country = 'Jordon'"));
            MaxSalary = Convert.ToDouble(dt.Compute("Max(Salary)", "Country = 'Jordon'"));

            Console.WriteLine("\n\nFilter 1 By Country Jordon:");

            foreach (DataRow Row in ResultRows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t Date: {4} \t"
                    , Row["ID"], Row["Name"], Row["Country"], Row["Salary"], Row["Date"]);
            }

            Console.WriteLine("\nCount : " + ResultCount);
            Console.WriteLine("Total Salaries : " + TotalSalaries);
            Console.WriteLine("Avg Salaries : " + AvgSalaries);
            Console.WriteLine("Min Salary : " + MinSalary);
            Console.WriteLine("Max Salary : " + MaxSalary);
            Console.WriteLine("//---------------------------------------------------------------------------------//");
            
//---------------------------------------------------------------------------------//

            // Filter 2 By Country Jordon And Egypt

            ResultRows = dt.Select("Country = 'Jordon' or Country = 'Egypt'");


            ResultCount= ResultRows.Count();
            TotalSalaries = Convert.ToDouble(dt.Compute("SUM(Salary)", "Country =  'Jordon' or Country = 'Egypt'"));
            AvgSalaries = Convert.ToDouble(dt.Compute("AVG(Salary)", "Country =  'Jordon' or Country = 'Egypt'"));
            MinSalary = Convert.ToDouble(dt.Compute("MIN(Salary)", "Country =  'Jordon' or Country = 'Egypt'"));
            MaxSalary = Convert.ToDouble(dt.Compute("Max(Salary)", "Country =  'Jordon' or Country = 'Egypt'"));

            Console.WriteLine("\n\nFilter 2 By Country Jordon And Egypt");

            foreach(DataRow Row in ResultRows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t Date: {4} \t"
                   , Row["ID"], Row["Name"], Row["Country"], Row["Salary"], Row["Date"]);

            }

            Console.WriteLine("\nCount : " + ResultCount);
            Console.WriteLine("Total Salaries : " + TotalSalaries);
            Console.WriteLine("Avg Salaries : " + AvgSalaries);
            Console.WriteLine("Min Salary : " + MinSalary);
            Console.WriteLine("Max Salary : " + MaxSalary);
            Console.WriteLine("//---------------------------------------------------------------------------------//");

//---------------------------------------------------------------------------------//

            // Filter 3 By ID "1"

            ResultRows = dt.Select("ID = 1");

            ResultCount= ResultRows.Count();
            TotalSalaries = Convert.ToDouble(dt.Compute("SUM(Salary)", "ID = '1'"));
            AvgSalaries = Convert.ToDouble(dt.Compute("AVG(Salary)", "ID = '1'"));
            MinSalary = Convert.ToDouble(dt.Compute("MIN(Salary)", "ID = '1'"));
            MaxSalary = Convert.ToDouble(dt.Compute("Max(Salary)", "ID = '1'"));


            Console.WriteLine("\n\nFilter 3 By ID = 1");

            foreach (DataRow Row in ResultRows)
            {
                Console.WriteLine("ID: {0} \t Name: {1} \t Country: {2} \t Salary: {3} \t Date: {4} \t"
                   , Row["ID"], Row["Name"], Row["Country"], Row["Salary"], Row["Date"]);

            }

            Console.WriteLine("\nCount : " + ResultCount);
            Console.WriteLine("Total Salaries : " + TotalSalaries);
            Console.WriteLine("Avg Salaries : " + AvgSalaries);
            Console.WriteLine("Min Salary : " + MinSalary);
            Console.WriteLine("Max Salary : " + MaxSalary);

        }
    }
}
