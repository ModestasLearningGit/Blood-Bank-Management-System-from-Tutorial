using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        donorDLL dal = new donorDLL();

        private void frmHome_Load(object sender, EventArgs e)
        {
            allDonorCount();

            DataTable dt = dal.Select();
            dgvDonors.DataSource = dt;

            lblUser.Text = frmLogin.loggedInUser;
        }
        public void allDonorCount()
        {
            lblOpossitiveCount.Text = dal.countDonors("O+");
            lblOnegativeCount.Text = dal.countDonors("O-");
            lblApossitiveCount.Text = dal.countDonors("A+");
            lblAnegativeCount.Text = dal.countDonors("A-");
            lblBpossitiveCount.Text = dal.countDonors("B+");
            lblBnegativeCount.Text = dal.countDonors("B-");
            lblABpossitiveCount.Text = dal.countDonors("AB+");
            lblABnegativeCount.Text = dal.countDonors("AB-");
        }
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open users form
            frmUser users = new frmUser();
            users.Show();
        }

        private void donorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonors donors = new frmDonors();
            donors.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmHome_Activated(object sender, EventArgs e)
        {
            allDonorCount();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.search(keywords);
                dgvDonors.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
            }
        }
        private void pannelFooter_Paint(object sender, PaintEventArgs e)
        {

        }



        private void lblAppName_Click(object sender, EventArgs e)
        {

        }

        private void lblDevTitle_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {                    }

        private void lblOpossitiveCount_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStripTop_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

       
    }
}
