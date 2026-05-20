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

namespace Barber_Booking_System
{
    public partial class User_Signup_Page : Form
    {
        SqlConnection _conn = new SqlConnection(Properties.Resources.DBConnectionString);
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
            _conn.Open();

            SqlCommand cmd = _conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into [CUSTOMER] (Name, Email, Password) values ('{tbUsername.Text}', '{tbEmail.Text}', '{tbPwd.Text}')";
            cmd.ExecuteNonQuery();

            _conn.Close();

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
