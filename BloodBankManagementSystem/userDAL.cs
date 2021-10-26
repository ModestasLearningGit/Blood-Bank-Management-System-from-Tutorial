using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    class userDAL
    {
        //Crreate a static string to connect database
        static string myconnstrn = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region SELECT data from database
        public DataTable Select()
        {
            //Create an object to connect database
            SqlConnection conn = new SqlConnection(myconnstrn);

            //Create datatable
            DataTable dt = new DataTable();

            try
            {
                //Write sql query to get data from database
                string sql = "SELECT * FROM tbl_users";

                //Create sql command to execute query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create sql data apadater to hold data from database temporary
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open database connnection
                conn.Open();

                //trasfer data from sqldata adapter to DataTable
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                //display error message
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //close db connection
                conn.Close();
            }

            return dt;
        }
        #endregion

        #region Inser data into databse for user module
        public bool Insert(userBLL u)
        {
            //Create boolean varialbe and set its default value to false
            bool isSuccess = false;

            //create an object of sqlconnection to connect to dababase
            SqlConnection conn = new SqlConnection(myconnstrn);

            try
            {
                //Create a String variable to store the query
                string sql = "INSERT INTO tbl_users(username, email, password, full_name, contact, address,  added_date, image_name) " +
                "VALUES(@username, @email, @password, @full_name, @contact, @address,  @added_date, @image_name)";

                //Create a sql command to pass the value into our query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create the parameters to pas get hte value fromUI and pass it on SqlQuery above
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);

                //open db connection
                conn.Open();

                //create and integer variable to hol value afte query is excecuted
                int rows = cmd.ExecuteNonQuery();

                //the value of rows will be greater than 0 if queery excecuted succesfully
                // else it will be 0
                if(rows > 0)
                {
                    //Query excecuted sufesfullly
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            return isSuccess;
        }
        #endregion

        #region   UPDATE data in database
        public bool Update(userBLL u)
        {
            bool isSuccess = false;

            //create an object for database connection
            SqlConnection conn = new SqlConnection(myconnstrn);

            try
            {
                string sql = "UPDATE tbl_users Set username=@username , email=@email ," +
                "password=@password , full_name=@full_name , contact=@contact , address=@address ," +
                "added_date=@added_date, image_name=@image_name WHERE user_id=@user_id";

                //Create sql commandt to execute query and pass the values to sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Pass the values to SQL query
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@full_name", u.full_name);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@image_name", u.image_name);
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

                //open db connection
                conn.Open();

                //create and integer variable to hol value afte query is excecuted
                int rows = cmd.ExecuteNonQuery();

                //the value of rows will be greater than 0 if queery excecuted succesfully
                // else it will be 0
                if (rows > 0)
                {
                    //Query excecuted sufesfullly
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion

        #region DELETE data from database
        public bool Delete(userBLL u)
        {
            bool isSuccess = false;

            //create an object for database connection
            SqlConnection conn = new SqlConnection(myconnstrn);

           

            try
            {
                string sql = "DELETE FROM tbl_users WHERE user_id=@user_id";
                 
                //Create sql commandt to execute query and pass the values to sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Pass the values to SQL query
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

                //open db connection
                conn.Open();

                //create and integer variable to hol value afte query is excecuted
                int rows = cmd.ExecuteNonQuery();

                //the value of rows will be greater than 0 if queery excecuted succesfully
                // else it will be 0
                if (rows > 0)
                {
                    //Query excecuted sufesfullly
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region  SEARCH
        public DataTable search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrn);

            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT * FROM tbl_users WHERE user_id LIKE '%" + keywords + "%' OR full_name LIKE  '%" + keywords + "%' OR address LIKE  '%" + keywords + "%'";
                
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        #endregion

        #region
        
        public userBLL GetIDfromUsername(string username)
        {
            userBLL u = new userBLL();

            SqlConnection conn = new SqlConnection(myconnstrn);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT user_id FROM tbl_users WHERE username='" + username + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                adapter.Fill(dt);

                if(dt.Rows.Count> 0)
                {
                    u.user_id = int.Parse(dt.Rows[0]["user_id"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return u;
        }
        #endregion
    }
}
