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
    public partial class User_Signup_Page : Form
    {
//asdefrdg
        public User_Signup_Page()
        {
            InitializeComponent();
        }

        private void btnBarberLoginPage_Click(object sender, EventArgs e)
        {
            Barber_Login_Page bloginPage = new Barber_Login_Page();
            this.Hide();
            bloginPage.ShowDialog();
            this.Close();
        }

        private void lnkUserLoginAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User_Login_Page loginPage = new User_Login_Page();
            this.Hide();
            loginPage.ShowDialog();
            this.Close();
        }

        private void btnUserSignup_Click(object sender, EventArgs e)
        {
            User_Home_Page homePage = new User_Home_Page();
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }
    }
}
