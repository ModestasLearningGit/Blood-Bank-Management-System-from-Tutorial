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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        LoginBLL l = new LoginBLL();
        LoginDAL dal = new LoginDAL();

        public static string loggedInUser;

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            l.Username = txtUsername.Text;
            l.password = txtPassword.Text;
            bool isSuccess = dal.loginCheck(l);

            if(isSuccess == true)
            {
                //LOGIN SUCCESS
                MessageBox.Show("LOGIN IS SUCCESSFUL");
                loggedInUser = l.Username;
                frmHome home = new frmHome();
                home.Show();
                this.Hide();
            }
            else
            {
                //LOGIN FAILED
                MessageBox.Show("CHECK YOUR ID OR PASSWORD AND TRY AGAIN");
            }
        }
    }
}
