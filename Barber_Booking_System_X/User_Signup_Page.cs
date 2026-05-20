using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Barber_Booking_System_X.models;

namespace Barber_Booking_System
{
    public partial class User_Signup_Page : Form
    {
        BekasIceCreamContext _db = new BekasIceCreamContext();
        
        public User_Signup_Page()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //openHomePage();
            userSignUp();
        }

        private void userSignUp()
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Email is empty!", "Error");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("Username is empty!", "Error");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPwd.Text))
            {
                MessageBox.Show("Password is empty!", "Error");
                return;
            }


            Customer customer = new Customer();
            customer.Email = tbEmail.Text.Trim();
            customer.Name = tbUsername.Text.Trim();
            customer.Password = tbPwd.Text;

            _db.Customers.Add(customer);
            _db.SaveChanges();

            MessageBox.Show("Signup successful! Please log in.");

            openLoginPage();
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
