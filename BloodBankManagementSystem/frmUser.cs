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
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
            
        }
        //create objects of userBLL and userDAL
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        string imageName = "no-image.jpg";
        string rowHeaderImage;

        string sourcePath = "";
        string destinationPath = "";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }
    

        //DELETE BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            u.user_id = int.Parse(txtUserID.Text);

            bool success = dal.Delete(u);

            if(rowHeaderImage != "no-image.jpg")
            {
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length));
                string imagePath = paths + "\\Image\\"  + rowHeaderImage;

                clear();

                GC.Collect();
                GC.WaitForPendingFinalizers();

                File.Delete(imagePath);
            }

            if(success)
            {
                MessageBox.Show("Data deleted successfully");
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Data failed to delete");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            u.full_name = txtFullName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;

            if(imageName != "no-image.jpg")
            {
                File.Copy(sourcePath, destinationPath);
            }

            bool success = dal.Insert(u);

            if(success == true)
            {
                MessageBox.Show("Data inserted successfully");

                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to insert data");
            }

        }
        public void clear()
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtUserID.Text = "";


            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length));
            string imagePath = paths + "\\Image\\no-image.jpg";
            PictureBoxProfilePicture.Image = new Bitmap(imagePath);

        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtFullName.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtContact.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            imageName = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();

            rowHeaderImage = imageName;
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length));

            if(imageName != "no-image.jpg")
            {
                
                string imagePath = paths + "Image\\" + imageName;
                PictureBoxProfilePicture.Image = new Bitmap(imagePath);
            }
            else
            {
                Console.WriteLine("INSADE NO-IMAGE");
                string imagePath = paths + "Image\\no-image.jpg" ;
                PictureBoxProfilePicture.Image = new Bitmap(imagePath);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            u.user_id = int.Parse(txtUserID.Text);
            u.full_name = txtFullName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;

            

            bool success = dal.Update(u);

            if(success)
            {
                MessageBox.Show("User updayted successfully");
                
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
                clear();
            }
            else
            {
                MessageBox.Show("Failed to update data");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.PNG;*.gif;) |*.jpg; *.jpeg; *.png; *.PNG;*.gif; ";
        
            if(open.ShowDialog() == DialogResult.OK)
            {
                if(open.CheckFileExists)
                {
                    PictureBoxProfilePicture.Image = new Bitmap(open.FileName);

                    string ext = Path.GetExtension(open.FileName);

                    Random random = new Random();
                    int RandInt = random.Next(0, 1000);

                    imageName = "Blood Bank_MS_" + RandInt + ext;

                    sourcePath = open.FileName;

                    string path = Application.StartupPath.Substring(0, Application.StartupPath.Length);

                    destinationPath = path + "\\Image\\" + imageName;

                    //File.Copy(sourcePath, destinationPath);

                   // MessageBox.Show("Image Uploaded Successfully");
                    
                }
                
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null) 
            {
                DataTable dt = dal.search(keywords);
                dgvUsers.DataSource = dt;
            } 
            else
            {
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
