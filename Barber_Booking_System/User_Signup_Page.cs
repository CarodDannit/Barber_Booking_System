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
        public User_Signup_Page()
        {
            InitializeComponent();
        }

        private void userSignupBtn_Click(object sender, EventArgs e)
        {
           openHomePage();
        }

        private void userLoginAccLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openLoginPage();
        }

        void openHomePage()
        {
            User_Home_Page homePage = new User_Home_Page();
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }

        void openLoginPage()
        {
            User_Login_Page loginPage = new User_Login_Page();
            this.Hide();
            loginPage.ShowDialog();
            this.Close();
        }


    }
}
