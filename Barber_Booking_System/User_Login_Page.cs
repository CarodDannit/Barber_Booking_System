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

        private void registerUserAccLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Console.WriteLine("register new account");
        }

        private void userLogInBtn_Click(object sender, EventArgs e)
        {
            openHomePage();
        }

        void openHomePage()
        {
            User_Home_Page homePage = new User_Home_Page();
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }
    }
}
