using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
class Program
{
    SqlConnection conn;
    static void Main(string[] args)
    {
        new Program();               
    }
    public Program()
    {
        conn =
         new SqlConnection(@"data source=SHUBHAMSHARMA\MSSQLSERVER01; initial Catalog=Scott;Integrated security=true");
        string ans = "y";
        do
        {
            Console.Write("Enter the year : ");
            int year = int.Parse(Console.ReadLine());
            DisplayData(year);
            Console.Write("Do you want to continue(y/n)");
            ans = Console.ReadLine();
        } while (ans == "y");
    }
    public void DisplayData(int year)
    {
        try
        {
            SqlCommand displayCount = new SqlCommand();
            displayCount.CommandText = "select count(empno) from emp where year(hiredate)=@year";
            SqlParameter dateParam = new SqlParameter("@year", year);
            displayCount.Parameters.Add(dateParam);
            displayCount.Connection = conn;
            conn.Open();
            object empCountObj = displayCount.ExecuteScalar();
            conn.Close();
            int empCount = int.Parse(empCountObj.ToString());
            Console.WriteLine("Total Number of employees in the year  : " + year + " is " + empCount);
        }
        catch (SqlException sqe)
        {
            Console.WriteLine(sqe.Message);
        }
        finally
        {
            conn.Close();
        }
    }


}
   




