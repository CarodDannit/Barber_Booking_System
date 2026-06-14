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
    public partial class Barber_Home_Page : Form
    {
        BekasIceCreamDbContext _db = Helper._db;
        Barber barber;
        public Barber_Home_Page(Barber b)
        {
            InitializeComponent();
            barber = b;
        }

        private void Barber_Home_Page_Load(object sender, EventArgs e)
        {
            dgvBookings.AutoGenerateColumns = false;
            dgvBookings.DataSource = _db.Bookings
                .Where(bk => bk.BarberId == barber.Id)
                .Select(bk => new
                {
                    bk.Id,
                    bk.Date,
                    bk.Description,
                    bk.OutletId,
                    oLocation = bk.Outlet.Location,
                    bk.CustId,
                    cName = bk.Cust.Name,
                    bk.ServiceId,
                    sName = bk.Service.Name,
                    bk.TimeslotId,
                    bk.Timeslot.Time,
                    bk.Status
                })
                .ToList();

            dgvBarber.AutoGenerateColumns = false;
            dgvBarber.DataSource = _db.Barbers
                .Select(br => new
                {
                    br.Id,
                    br.Name,
                    br.Email,
                    br.Gender,
                    oLocation = br.Outlet.Location
                })
                .ToList();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var bbS = new Barber_Signup_Page();
            this.Hide();
            var resultSignUp = bbS.ShowDialog();
            if (resultSignUp == DialogResult.Cancel)
            {
                this.Show();
                bbS.Close();
            }
            else this.Close();
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
            lblCustomer.Text = row.Cells["cName"].Value?.ToString();
            lblOutlet.Text = row.Cells["OutletLocation"].Value?.ToString();
            lblDate.Text = row.Cells["Date"].Value.ToString();
            lblTimeSlot.Text = row.Cells["Time"].Value?.ToString();
            lblStatus.Text = row.Cells["Status"].Value?.ToString();
        }

        private void btnCheckBooking_Click(object sender, EventArgs e)
        {


            var bookingId = _db.Bookings
                            .Include(b => b.Service)
                            .Include(b => b.Cust)
                            .Include(b => b.Outlet)
                            .Include(b => b.Timeslot)
                            .FirstOrDefault(b => b.Id == Convert.ToInt32(lblBookingId.Text));

            Check_Barber_Booking_Page checkBooking = new Check_Barber_Booking_Page(bookingId);
            checkBooking.Show();
        }

        private void dgvBarber_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvBarber.Rows[e.RowIndex];

            tbBarberId.Text = row.Cells["BarberId02"].Value?.ToString();
            tbBarberName.Text = row.Cells["BarberName"].Value?.ToString();
            tbBarberEmail.Text = row.Cells["BarberEmail"].Value?.ToString();
            tbBarberGender.Text = row.Cells["BarberGender"].Value?.ToString();
            tbBarberOutlet.Text = row.Cells["BarberOutlet"].Value?.ToString();
        }

       
    }
}
