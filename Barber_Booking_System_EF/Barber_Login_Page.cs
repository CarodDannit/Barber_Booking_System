using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barber_Booking_System_EF.models;
namespace Barber_Booking_System_EF
{
    public partial class Barber_Login_Page : Form
    {
        BekasIceCreamDbContext _db = Helper._db;

        public Barber_Login_Page()
        {
            InitializeComponent();
        }

        private void btnUserLoginPage_Click(object sender, EventArgs e)
        {
            User_Login_Page loginPage = new User_Login_Page();
            this.Hide();
            loginPage.ShowDialog();
            this.Close();
        }

        private void btnBarberLogin_Click(object sender, EventArgs e)
        {
            var barBerFromDB = _db.Barbers.FirstOrDefault(c => c.Email == tbEmail.Text);
            if (barBerFromDB == null)
            {
                MessageBox.Show("Email not found!");
                return;
            }
            if (barBerFromDB.Password != tbPassword.Text)
            {
                MessageBox.Show("Incorrect password!");
                return;
            }

            var bhomepage = new Barber_Home_Page(barBerFromDB);
            this.Hide();
            bhomepage.ShowDialog();
            this.Close();
        }
    }
}
