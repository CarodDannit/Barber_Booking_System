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
    public partial class Barber_ViewBooking : Form
    {
        Booking booking;
        public Barber_ViewBooking(Booking b)
        {
            InitializeComponent();
            booking = b;
        }

        private void ViewBookingDetails_Page_Load(object sender, EventArgs e)
        {
            labelId.Text = booking.Id.ToString();
            labelDate.Text = booking.Date.ToLongDateString();
            labelOutlet.Text = booking.Outlet.Location;
            labelTimeslot.Text = booking.Timeslot.Time.ToShortTimeString();
            labelService.Text = booking.Service.Name;
            labelPrice.Text = $"RM {booking.Service.Price.ToString("F2")}";
            labelStatus.Text = booking.Status;
            labelCust.Text = booking.Cust.Name;
            labelEmail.Text = $"Email: {booking.Cust.Email}";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
