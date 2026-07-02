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
    public partial class Landing_Page : Form
    {
        public Landing_Page()
        {
            InitializeComponent();
        }

        private void btnBarberLogInPage_Click(object sender, EventArgs e)
        {
            Barber_Login_Page bloginPage = new Barber_Login_Page();
            this.Hide();
            bloginPage.ShowDialog();
            this.Show();
        }

        private void btnUserLogInPage_Click(object sender, EventArgs e)
        {
            User_Login_Page uloginPage = new User_Login_Page();
            this.Hide();
            uloginPage.ShowDialog();
            this.Show();
        }
    }
}
