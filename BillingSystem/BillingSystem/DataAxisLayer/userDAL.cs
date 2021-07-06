using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillingSystem.BusinessLogic;

namespace BillingSystem.DataAxisLayer
{
    class userDAL
    {
        static string myconstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

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

        #region Insert Data in Database

        public bool insert(UserBL u)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myconstring);
            try
            {
                string ins = "INSERT INTO UserTable(first_name, last_name, email, username, password, contact, address, gender, user_type, added_date, added_by) VALUES (@first_name, @last_name, @email, @username, @password, @contact, @address, @gender, @user_type, @added_date, @added_by)";
                SqlCommand com = new SqlCommand(ins, con);
                com.Parameters.AddWithValue("@first_name", u.firstname);
                com.Parameters.AddWithValue("@last_name", u.lastname);
                com.Parameters.AddWithValue("@email", u.email);
                com.Parameters.AddWithValue("@username", u.username);
                com.Parameters.AddWithValue("@password", u.password);
                com.Parameters.AddWithValue("@contact", u.contact);
                com.Parameters.AddWithValue("@address", u.address);
                com.Parameters.AddWithValue("@gender", u.gender);
                com.Parameters.AddWithValue("@user_type", u.usertype);
                com.Parameters.AddWithValue("@added_date", u.addeddate);
                com.Parameters.AddWithValue("@added_by", u.addedby);

                con.Open();

                int rows = com.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(SqlException s)
            {
                MessageBox.Show(s.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

        #endregion

        #region Update Data in Database

        public bool update(UserBL u)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(myconstring);
            try
            {
                string sql = "UPDATE UserTable SET first_name = @first_name, last_name = @last_name, email = @email, username = @username, password = @password, contact = @contact, address = @address, gender = @gender, user_type = @user_type, added_date = @added_date, added_by = @added_by WHERE id = @id";
                SqlCommand com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@first_name", u.firstname);
                com.Parameters.AddWithValue("@last_name", u.lastname);
                com.Parameters.AddWithValue("@email", u.email);
                com.Parameters.AddWithValue("@username", u.username);
                com.Parameters.AddWithValue("@password", u.password);
                com.Parameters.AddWithValue("@contact", u.contact);
                com.Parameters.AddWithValue("@address", u.address);
                com.Parameters.AddWithValue("@gender", u.gender);
                com.Parameters.AddWithValue("@user_type", u.usertype);
                com.Parameters.AddWithValue("@added_date", u.addeddate);
                com.Parameters.AddWithValue("@added_by", u.addedby);
                com.Parameters.AddWithValue("@id", u.id);

                con.Open();

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(SqlException s)
            {
                MessageBox.Show(s.Message);
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }

        #endregion

        #region deleet Data from Database


        public bool delete(UserBL u)
        {
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(myconstring);

            try
            {
                string sql = "DELETE FROM UserTable WHERE id = @id;";

                SqlCommand com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@id", u.id);
                con.Open();

                int rows = com.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(SqlException s)
            {
                MessageBox.Show(s.Message);
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }

        #endregion

        #region Search user by key words

        public DataTable Search(string keywords)
        {
            SqlConnection con = new SqlConnection(myconstring);

            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM UserTable WHERE id LIKE '%" + keywords + "%' OR first_name LIKE '%" + keywords + "%' OR last_name LIKE '%" + keywords + "%' OR username LIKE '%" + keywords + "%'";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataAdapter ad = new SqlDataAdapter(com);
                con.Open();
                ad.Fill(dt);
            }
            catch (Exception ex)
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
