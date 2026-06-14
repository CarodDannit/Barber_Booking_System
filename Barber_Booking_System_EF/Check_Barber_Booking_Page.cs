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
    public partial class Check_Barber_Booking_Page : Form
    {
        BekasIceCreamDbContext _db = Helper._db;
        Booking booking;
        public Check_Barber_Booking_Page(Booking b)
        {
            InitializeComponent();
            booking = b;
        }

        private void Check_Barber_Booking_Page_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text + " " + booking.Id.ToString();
            lblBookingId.Text = booking.Id.ToString();
            lblService.Text = booking.Service.Name.ToString();
            lblCustomer.Text = booking.Barber.Name.ToString();
            lblOutlet.Text = booking.Outlet.Location.ToString();
            lblDate.Text = booking.Date.ToString();
            lblTimeSlot.Text = booking.Timeslot.Time.ToString();
            lblStatus.Text = booking.Status.ToString();
        }
    }
}
