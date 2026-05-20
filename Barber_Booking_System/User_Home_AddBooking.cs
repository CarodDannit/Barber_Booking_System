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
    public partial class User_Home_AddBooking : Form
    {
        BekasIceCream _ds = new BekasIceCream();
        public User_Home_AddBooking()
        {
            InitializeComponent();
        }

        private void bOOKINGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bOOKINGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bekasIceCream);

        }

        private void User_Home_AddBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bekasIceCream.BOOKING' table. You can move, or remove it, as needed.
            this.bOOKINGTableAdapter.Fill(this.bekasIceCream.BOOKING);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _ds.acc
        }
    }
}
