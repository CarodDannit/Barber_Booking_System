using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//cghndjkvhejhbwwwwwww
namespace Barber_Booking_System_EF
{
    public partial class Barber_Login_Page : Form
    {
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
            Barber_Signup_Page bsignupPage = new Barber_Signup_Page();
            this.Hide();
            bsignupPage.ShowDialog();
            this.Close();
        }
    }
}
