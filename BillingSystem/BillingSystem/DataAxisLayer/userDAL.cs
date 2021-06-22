using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem.DataAxisLayer
{
    class userDAL
    {
        static string myconstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Select data from database
        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(myconstring);

            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM UserTable";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataAdapter ad = new SqlDataAdapter(com);
                con.Open();
                ad.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        #endregion
    }
}
