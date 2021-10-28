using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class frmDonors : Form
    {
        donorBLL d = new donorBLL();
        donorDLL dal = new donorDLL();
        userDAL udal = new userDAL();

        string image_name = "no-image.jpg";

        string rowHeaderImage;

        string sourcePath = " ";
        string destinationPath = " ";
        public frmDonors()
        {
            InitializeComponent();
            clear();
        }
        private void frmDonors_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvDonors.DataSource = dt;
        }
        private void dgvDonors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtDonorID.Text = dgvDonors.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvDonors.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvDonors.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDonors.Rows[rowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvDonors.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvDonors.Rows[rowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dgvDonors.Rows[rowIndex].Cells[6].Value.ToString();
            cmbBloodGroup.Text = dgvDonors.Rows[rowIndex].Cells[7].Value.ToString();

            image_name = dgvDonors.Rows[rowIndex].Cells[9].Value.ToString();
            rowHeaderImage = image_name;

            //Display image  of selected donnor
            string path = Application.StartupPath.Substring(0, Application.StartupPath.Length); // use - to shorten it
            string image_path = path + "Image\\" + image_name;

            PictureBoxProfilePicture.Image = new Bitmap(image_path);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            d.first_name = txtFirstName.Text;
            d.last_name = txtLastName.Text;
            d.email = txtEmail.Text;
            d.gender = cmbGender.Text;
            d.blood_group = cmbBloodGroup.Text;
            d.contact = txtContact.Text;
            d.address = txtAddress.Text;
            d.added_date = DateTime.Now;
            //get id of logged in user
            string loggedInUser = frmLogin.loggedInUser;
            userBLL usr = udal.GetIDfromUsername(loggedInUser);
            d.added_by = usr.user_id;  
            
            d.image_name = image_name;

            if(image_name != "no-image.jpg")
            {
                File.Copy(sourcePath, destinationPath);
            }

            bool isSuccess = dal.Insert(d);

            if(isSuccess == true)
            {
                MessageBox.Show("DATA INSERTED SUCCESFULLY");

                //TODO REFRESH DATA GRID VIEW
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;

                //clear text boxes
                clear();
            }
            else
            {
                MessageBox.Show("DATA FAILED TO INSERT");
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            d.donor_id = int.Parse(txtDonorID.Text);
            d.first_name = txtFirstName.Text;
            d.last_name = txtLastName.Text;
            d.email = txtEmail.Text;
            d.gender = cmbGender.Text;
            d.blood_group = cmbBloodGroup.Text;
            d.contact = txtContact.Text;
            d.address = txtAddress.Text;

            string loggedInUser = frmLogin.loggedInUser;
            userBLL usr = udal.GetIDfromUsername(loggedInUser);
            d.added_by = usr.user_id;

            d.image_name = image_name;

            bool isSucces = dal.Update(d);

            if(isSucces == true)
            {
                MessageBox.Show("DATA UPDATED");
                clear();

                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
            }
            else
            {
                MessageBox.Show("DATA UPDATE FAILED");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            d.donor_id = int.Parse(txtDonorID.Text);

            bool isSuccess = dal.Delete(d);

            if (rowHeaderImage != "no-image.jpg")
            {
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length));
                string imagePath = paths + "\\Image\\" + rowHeaderImage;

                clear();

                GC.Collect();
                GC.WaitForPendingFinalizers();

                File.Delete(imagePath);
            }


            if (IsHandleCreated == true)
            {
                MessageBox.Show("DONOR DELETED SUCCESSFULLY");
                clear();

                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
            }
            else
            {
                MessageBox.Show("DONOR FAILED TO DELETE ");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files Only (*.jpg; *.jpeg; *.png; *.gif | *.jpg; *.jpeg; *.png; *.gif)";

            if(open.ShowDialog() == DialogResult.OK)
            {
                if(open.CheckFileExists)
                {
                    PictureBoxProfilePicture.Image = new Bitmap(open.FileName);

                    string ext = Path.GetExtension(open.FileName);
                    string name = Path.GetFileNameWithoutExtension(open.FileName);

                    Guid g = new Guid();
                    g = Guid.NewGuid();

                    image_name = "Blood_banl_MS_" + name + g + ext;

                    sourcePath = open.FileName;

                    string path = Application.StartupPath.Substring(0, Application.StartupPath.Length);
                    destinationPath = path + "Image\\" + image_name;

                    //File.Copy(sourcePath, destinationPath);

                    //MessageBox.Show("IMAGE UPLOADED SUCESSFULLY");
                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if(keywords != null)
            {
               DataTable dt =  dal.search(keywords);
                dgvDonors.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
            }
        }
        public void clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            cmbGender.Text = "";
            cmbBloodGroup.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtDonorID.Text = "";
            image_name = "no-image.jpg";

            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length));
            string imagePath = path + "Image\\no-image.jpg";

            PictureBoxProfilePicture.Image = new Bitmap(imagePath);
            
            
        }

        private void dgvDonors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
