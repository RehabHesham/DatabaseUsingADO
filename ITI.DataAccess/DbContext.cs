using Microsoft.Data.SqlClient;
using System.Data;

namespace ITI.DataAccess
{
    public class DbContext
    {
        SqlConnection con = new SqlConnection("Server= .; Database=iti; Trusted_Connection=True; TrustServerCertificate=True");
        public DataTable Select(string cmdText)
        {
            // using disconnected mode
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand(cmdText, con);
            da.SelectCommand = cmd;

            da.Fill(dt);

            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmdText"> text of insert or update or delete command</param>
        /// <returns>number of rows affected</returns>
        public int ExecuteNonQuery(string cmdText)
        {
            // connected mode   
            SqlCommand cmd = new SqlCommand(cmdText, con);
            int rows = 0;
            try
            {
                con.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();

            }

            return rows;
        }
    }
}
