using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    class donorDLL
    {
        static string myconnstrn = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        #region  SELECT to display data from DB
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(myconnstrn);

            try
            {
                string sql = "SELECT * FROM  tbl_donors";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);
            }
            catch (Exception ex)
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

        #region INSERT DATA TO DB
        public bool Insert(donorBLL d)
        {
            //Create boolean varialbe and set its default value to false
            bool isSuccess = false;

            //create an object of sqlconnection to connect to dababase
            SqlConnection conn = new SqlConnection(myconnstrn);

            try
            {
                string sql = "INSERT INTO tbl_donors(first_name,  last_name, email, contact, gender, address, blood_group,  added_date, image_name, added_by) " +
             "VALUES(@first_name,@last_name, @email, @contact, @gender, @address, @blood_group, @added_date, @image_name, @added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@first_name", d.first_name);
                cmd.Parameters.AddWithValue("@last_name", d.last_name);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@contact", d.contact);
                cmd.Parameters.AddWithValue("@gender", d.gender);
                cmd.Parameters.AddWithValue("@address", d.address);
                cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
                cmd.Parameters.AddWithValue("@added_date", d.added_date);
                cmd.Parameters.AddWithValue("@image_name", d.image_name);
                cmd.Parameters.AddWithValue("@added_by", d.added_by);

                conn.Open();

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

        #region UPDATE DATA IN DB
        public bool Update(donorBLL d)
        {
            bool isSuccess = false;

            //create an object for database connection
            SqlConnection conn = new SqlConnection(myconnstrn);

            try
            {
                string sql = "UPDATE tbl_donors Set first_name=@first_name,last_name=@last_name , email=@email ," +
            "contact=@contact , gender=@gender, address=@address , blood_group=@blood_group" +
            ", image_name=@image_name, added_by=@added_by WHERE donor_id=@donor_id";

                //Create sql commandt to execute query and pass the values to sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@first_name", d.first_name);
                cmd.Parameters.AddWithValue("@last_name", d.last_name);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@contact", d.contact);
                cmd.Parameters.AddWithValue("@gender", d.gender);
                cmd.Parameters.AddWithValue("@address", d.address);
                cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
                cmd.Parameters.AddWithValue("@image_name", d.image_name);
                cmd.Parameters.AddWithValue("@added_by", d.added_by);
                cmd.Parameters.AddWithValue("@donor_id", d.donor_id);


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

        #region DELETE DATA IN DB
        public bool Delete(donorBLL d)
        {
            bool isSuccess = false;

            //create an object for database connection
            SqlConnection conn = new SqlConnection(myconnstrn);

            try
            {
                string sql = "DELETE FROM tbl_donors WHERE donor_id=@donor_id";

                //Create sql commandt to execute query and pass the values to sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Pass the values to SQL query
                cmd.Parameters.AddWithValue("@donor_id", d.donor_id);

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

        #region COUNT DONORS FOR SPECIFIC BLOOD GROUP

        public string countDonors(string blood_group)
        {
            SqlConnection conn = new SqlConnection(myconnstrn);

            string donors = "0";

            try
            {
                string sql = "SELECT * FROM tbl_donors WHERE blood_group = '" + blood_group + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                donors = dt.Rows.Count.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return donors;
        }
        #endregion

        #region SEARCH DONORS METHOD

        public DataTable search(string keywords)
        {

            SqlConnection conn = new SqlConnection(myconnstrn);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_donors WHERE donor_id LIKE '%" + keywords + "%' OR first_name LIKE '%" + keywords + "%'" +
                "OR last_name LIKE '%" + keywords + "%' OR email LIKE '%" + keywords + "%' OR blood_group LIKE '%" + keywords + "%'";

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
    }
}
