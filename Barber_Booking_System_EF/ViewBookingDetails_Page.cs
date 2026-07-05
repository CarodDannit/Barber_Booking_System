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
    public partial class ViewBookingDetails_Page : Form
    {
        Booking booking;
        public ViewBookingDetails_Page(Booking b)
        {
            InitializeComponent();
            booking = b;
        }

        private void ViewBookingDetails_Page_Load(object sender, EventArgs e)
        {
            tbId.Text = booking.Id.ToString();
            tbDate.Text = booking.Date.ToLongDateString();
            tbTimeslot.Text = booking.Timeslot.Time.ToShortTimeString();
            tbOutlet.Text = booking.Outlet.Location;
            tbService.Text = booking.Service.Name;
            tbPrice.Text = $"RM {booking.Service.Price.ToString("F2")}";
            tbDesc.Text = booking.Description;
            labelStatus.Text = booking.Status;
            labelBarber.Text = booking.Barber.Name;
            labelEmail.Text = $"Email: {booking.Barber.Email}";

            // get barber's pfp
            //   check if 0
            bool isZero = true;
            for (int i = 0; i < booking.Barber.Pfp.Length; i++)
            {
                if (booking.Barber.Pfp[i] != 0)
                {
                    isZero = false;
                    break; // Stop immediately upon finding a non-zero byte
                }
            }
            //   read pfp
            if (!isZero)
            {
                var ms = new MemoryStream(booking.Barber.Pfp);
                pictureBoxBarber.Image = new Bitmap(ms);
                ms.Dispose();
            }
            else
            {
                pictureBoxBarber.Image = Properties.Resources.rukia04;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            booking.Description = tbDesc.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
