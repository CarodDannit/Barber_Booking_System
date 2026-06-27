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
            dgvBookings.AutoGenerateColumns = false;
        }

        private void LoadBooking()
        {
            var bookings = _db.Bookings
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
            foreach(var b in bookings)
            {
                dgvBookings.Rows.Add(
                    b.Id,b.Date,b.Description,b.OutletId,b.oLocation,b.BarberId,b.bName,b.ServiceId,b.sName,b.TimeslotId,b.Time,b.Status
                );
            }
        }

        // load data when form loads
        private void User_Home_Page_Load(object sender, EventArgs e)
        {
            tbName.Text = customer.Name;
            tbEmail.Text = customer.Email;

            LoadBooking();

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
            lblDate.Text = row.Cells["Date"].Value.ToString();
            lblStatus.Text = row.Cells["Status"].Value?.ToString();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            User_Edit_Profile editProf = new User_Edit_Profile();
            editProf.Show();
            this.Hide();
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tbEmail.ReadOnly = false;
            tbName.ReadOnly = false;

            tbName.Text = customer.Name;
            tbEmail.Text = customer.Email;
            tbPassword.Text = customer.Password;

            label6.Visible = true;
            tbPassword.Visible = true;
            tbPassword.ReadOnly = false;
            btnSave.Visible = true;
            btnCancelProfile.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // validate input
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Name cannot be empty.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Email cannot be empty.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Password cannot be empty.");
                return;
            }

            tbEmail.ReadOnly = true;
            tbName.ReadOnly = true;

            customer.Name = tbName.Text;
            customer.Email = tbEmail.Text;
            customer.Password = tbPassword.Text;
            _db.SaveChanges();

            label6.Visible = false;
            tbPassword.Visible = false;
            tbPassword.ReadOnly = true;
            btnSave.Visible = false;
            btnCancelProfile.Visible = false;
        }

        private void btnCancelProfile_Click(object sender, EventArgs e)
        {
            tbEmail.ReadOnly = true;
            tbName.ReadOnly = true;

            // reset changes to textboxes
            tbName.Text = customer.Name;
            tbEmail.Text = customer.Email;
            tbPassword.Text = customer.Password;

            label6.Visible = false;
            tbPassword.Visible = false;
            tbPassword.ReadOnly = true;
            btnSave.Visible = false;
            btnCancelProfile.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            User_Login_Page loginPage = new User_Login_Page();
            loginPage.ShowDialog();
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            Book_Appointment_Page newbookingpage = new Book_Appointment_Page(customer);
            var result = newbookingpage.ShowDialog();
            if (result == DialogResult.OK)
                LoadBooking();
            newbookingpage.Close();
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (lblBookingId.Text == null || lblBookingId.Text == "")
            {
                MessageBox.Show("Pls select a booking"); return;
            }

            int bookingId = int.Parse(lblBookingId.Text);


            var booking = _db.Bookings.FirstOrDefault(b => b.Id == bookingId);
            if (booking == null)
            {
                MessageBox.Show("Booking not found");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you confirm to delete this booking? " + lblBookingId.Text,
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _db.Bookings.Remove(booking);
                _db.SaveChanges();

                MessageBox.Show("Booking deleted successfully");

                LoadBooking();
                lblBookingId.Text = "";
                lblService.Text = "";
                lblDate.Text = "";
                lblStatus.Text = "";
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblBookingId.Text)) return;

            int bookingId = int.Parse(lblBookingId.Text);
            var booking = _db.Bookings
                .Include(b => b.Barber)
                .Include(b => b.Outlet)
                .Include(b => b.Service)
                .Include(b => b.Timeslot)
                .Where(b => b.Id == bookingId)
                .FirstOrDefault();

            var viewdetailspage = new ViewBookingDetails_Page(booking);
            var result = viewdetailspage.ShowDialog();
            if (result == DialogResult.OK)
            {
                _db.SaveChanges();
                LoadBooking();
            }

            viewdetailspage.Dispose();
        }
    }
}