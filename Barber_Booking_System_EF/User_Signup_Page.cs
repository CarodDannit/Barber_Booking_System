using Barber_Booking_System_EF.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barber_Booking_System_EF
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
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Email cannot be empty!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("Username cannot be empty!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Password cannot be empty!");
                return;
            }

            var newCust = new Customer()
            {
                Email = tbEmail.Text,
                Name = tbUsername.Text,
                Password = tbPassword.Text
            };

            Helper._db.Add(newCust);
            Helper._db.SaveChanges();

            MessageBox.Show("User created successfully!");

            User_Home_Page homePage = new User_Home_Page(newCust);
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
