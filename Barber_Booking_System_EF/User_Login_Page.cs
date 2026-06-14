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
    public partial class User_Login_Page : Form
    {
        BekasIceCreamDbContext _db = Helper._db;

        public User_Login_Page()
        {
            InitializeComponent();
        }

        //private void btnBarbersignup_Click(object sender, EventArgs e)
        //{
        //    Barber_Signup_Page bsignupPage = new Barber_Signup_Page();
        //    this.Hide();
        //    bsignupPage.ShowDialog();
        //    this.Close();
        //}

        private void lnkUserRegisterAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User_Signup_Page signupPage = new User_Signup_Page();
            this.Hide();
            signupPage.ShowDialog();
            this.Close();
        }
        private void btnBarberLoginPage_Click(object sender, EventArgs e)
        {
            Barber_Login_Page bloginPage = new Barber_Login_Page();
            this.Hide();
            bloginPage.ShowDialog();
            this.Close();
        }

        // login
        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            // ! validate textboxes are not empty first !

            if (String.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Email cannot be empty!");
                return;
            }
            if (String.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Password cannot be empty!");
                return;
            }

            var customerFromDB = _db.Customers.FirstOrDefault(c => c.Email == tbEmail.Text);
            if (customerFromDB == null)
            {
                MessageBox.Show("Email not found!");
                return;
            }
            if (customerFromDB.Password != tbPassword.Text)
            {
                MessageBox.Show("Incorrect password!");
                return;
            }

            User_Home_Page homePage = new User_Home_Page(customerFromDB);
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    var bhomepage = new Barber_Home_Page(_db.Barbers.Find(5));
        //    this.Hide();
        //    bhomepage.ShowDialog();
        //    this.Close();
        //}
    }
}
