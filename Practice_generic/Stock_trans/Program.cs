using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace Stock_trans
{
    
    class Program
    {
        SqlConnection conn;
        static void Main(string[] args)
        {
            new Program();
        }
        public  Program()
        {
            using (TransactionScope ts=new TransactionScope())
            {

                try
                {


                    Console.WriteLine("Enter stockid");
                    int stockid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter stockval");
                    int stockval = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter transtype");
                    string transtype = Console.ReadLine();

                    conn = new SqlConnection(@"data source=SHUBHAMSHARMA\MSSQLSERVER01; initial Catalog=Scott;Integrated security=true");

                    SqlCommand insertCommand = new SqlCommand();
                    insertCommand.CommandText = "insert into stockTrans values(@stockid,@stockval,@transtype)";
                    insertCommand.Connection = conn;

                    //Query to update Stock
                    SqlCommand updateStock = new SqlCommand();
                    if (transtype == "SELL")
                        updateStock.CommandText = "update Stock set stockqty=stockqty-@stockval where stockid=@stockid";
                    else
                        updateStock.CommandText = "update Stock set stockqty=stockqty+@stockval where stockid=@stockid";
                    updateStock.Connection = conn;

                    //Creating all parameter
                    SqlParameter[] insertParam = new SqlParameter[3];
                    insertParam[0] = new SqlParameter("@stockid", stockid);
                    insertParam[1] = new SqlParameter("@stockval", stockval);
                    insertParam[2] = new SqlParameter("@transtype", transtype);

                    //Adding parameter for InsertStockTrans
                    insertCommand.Parameters.AddRange(insertParam);

                    //Adding parameter for UpdateStock
                    updateStock.Parameters.Add(new SqlParameter("@stockid", stockid));
                    updateStock.Parameters.Add(new SqlParameter("@stockval", stockval));

                    conn.Open();
                    insertCommand.ExecuteNonQuery();
                    updateStock.ExecuteNonQuery();
                    Console.WriteLine("Transaction Successfull");
                    ts.Complete();
                }


                catch (SqlException sqe)
                {
                    Console.WriteLine(sqe.Message);
                    ts.Dispose();
                }
                catch (Exception eq)
                {
                    Console.WriteLine(eq.Message);
                    ts.Dispose();
                }
                finally
                {
                    conn.Close();
                }
            }
        }
           
        
    }
}
