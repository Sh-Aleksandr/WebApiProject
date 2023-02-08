using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().DisplayData();
            Console.ReadKey();
        }
        public void DisplayData()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=; database=;integrated security=SSPI");

                // writing sql query  
                SqlCommand cm = new SqlCommand("Select * from student", con);

                // Opening Connection  
                con.Open();

                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();

                // Iterating Data  
                while (sdr.Read())
                {
                    // Displaying Record  
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}