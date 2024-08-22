using System.Data;
using System.Data.SqlClient;
namespace FinanceSys_Test
{
    public class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter Sda;
        private string ConStr;

        public Functions()
        {
            //Con = new SqlConnection(ConStr);
            //ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lacso\Documents\Finance.mdf;Integrated Security=True;Connect Timeout=30";
            //Cmd = new SqlCommand();
            //Cmd.Connection = Con;

            // Initialize the connection string first
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lacso\Documents\Finance.mdf;Integrated Security=True;Connect Timeout=30";

            // Now initialize the SqlConnection
            Con = new SqlConnection(ConStr);

            // Initialize the SqlCommand
            Cmd = new SqlCommand
            {
                Connection = Con
            };
        }

        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Query, ConStr);
            Sda.Fill(dt);
            return dt;
        }

        public int SetData(string Query)
        {
            int Cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            Cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            return Cnt;
        }
    }
}
