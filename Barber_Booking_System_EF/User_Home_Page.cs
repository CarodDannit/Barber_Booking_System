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
            tbName.Text = customer.Name;
            tbEmail.Text = customer.Email;


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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            tbEmail.ReadOnly = false;
            tbName.ReadOnly = false;

            // ahmad bolz EF core style
            tbName.Text = customer.Name;
            tbEmail.Text = customer.Email;
            tbPassword.Text = customer.Password;

            label6.Visible = true;
            tbPassword.Visible = true;
            tbPassword.ReadOnly = false;
            btnSave.Visible = true;
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

            label6.Visible = false;
            tbPassword.Visible = false;
            tbPassword.ReadOnly = true;
            btnSave.Visible = false;

            _db.SaveChanges();
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
            newbookingpage.ShowDialog();
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}