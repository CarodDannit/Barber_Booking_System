using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barber_Booking_System
{
    public partial class User_Login_Page : Form
    {
        public User_Login_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Barber_Signup_Page bsignupPage = new Barber_Signup_Page();
            this.Hide();
            bsignupPage.ShowDialog();
            this.Close();
        }

        private void lnkUserRegisterAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User_Signup_Page signupPage = new User_Signup_Page();
            this.Hide();
            signupPage.ShowDialog();
            this.Close();
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            User_Home_Page homePage = new User_Home_Page();
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }

        private void btnBarberLoginPage_Click(object sender, EventArgs e)
        {
            Barber_Login_Page bloginPage = new Barber_Login_Page();
            this.Hide();
            bloginPage.ShowDialog();
            this.Close();
        }
    }
}
