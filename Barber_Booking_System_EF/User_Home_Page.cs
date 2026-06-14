using Barber_Booking_System_EF.models;
using Microsoft.EntityFrameworkCore;
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
    public partial class User_Home_Page : Form
    {
        BekasIceCreamDbContext _db = Helper._db;
        Customer customer;
        //List<Booking> bookings;
        public User_Home_Page(Customer c)
        {
            InitializeComponent();
            customer = c;
        }

        // load data when form loads
        private void User_Home_Page_Load(object sender, EventArgs e)
        {
            Console.WriteLine("load hometyrtyrtyrtyrt page");
            tbName.Text = customer.Name;
            tbEmail.Text = customer.Email;

            //bookings = _db.Bookings
            //    .Where(b => b.CustId == customer.Id)
            //    .ToList();

            dgvBookings.AutoGenerateColumns = false;
            dgvBookings.DataSource = _db.Bookings
                .Where(b => b.CustId == customer.Id)
                .Select(b => new
                {
                    b.Id,
                    b.Date,
                    b.Description,
                    b.OutletId,
                    oLocation = b.Outlet.Location,
                    b.BarberId,
                    bName = b.Barber.Name,
                    b.ServiceId,
                    sName = b.Service.Name,
                    b.TimeslotId,
                    b.Timeslot.Time,
                    b.Status
                })
                .ToList();


        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
        }

        private void dgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvBookings.Rows[e.RowIndex];

            lblBookingId.Text = row.Cells["Id"].Value?.ToString();
            lblService.Text = row.Cells["ServiceName"].Value?.ToString();
            lblBarber.Text = row.Cells["BarberName"].Value?.ToString();
            lblOutlet.Text = row.Cells["OutletLocation"].Value?.ToString();
            lblDate.Text = row.Cells["Date"].Value.ToString();
            lblTimeSlot.Text = row.Cells["Time"].Value?.ToString();
            lblStatus.Text = row.Cells["Status"].Value?.ToString();
        }

        private void btnCheckBooking_Click(object sender, EventArgs e)
        {
            var bookingId = _db.Bookings
                            .Include(b => b.Service)
                            .Include(b => b.Barber)
                            .Include(b => b.Outlet)
                            .Include(b => b.Timeslot)
                            .FirstOrDefault(b => b.Id == Convert.ToInt32(lblBookingId.Text));

            Check_User_Booking_Page checkBooking = new Check_User_Booking_Page(bookingId);
            checkBooking.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Edit_Profile editProf = new User_Edit_Profile();
            editProf.Show();
            this.Hide();
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            Book_Appointment_Page newbookingpage = new Book_Appointment_Page(customer);
            newbookingpage.ShowDialog();
        }
    }
}