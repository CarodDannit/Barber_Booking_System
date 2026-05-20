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
    public partial class User_Home_Page : Form
    {
        public User_Home_Page()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Console.WriteLine("load hometyrtyrtyrtyrt page");
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            User_Home_AddBooking addBooking = new User_Home_AddBooking();
            addBooking.ShowDialog();
        }

        private void bOOKINGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }
    }
}
