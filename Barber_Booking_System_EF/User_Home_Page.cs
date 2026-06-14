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

        private void button1_Click(object sender, EventArgs e)
        {
            User_Edit_Profile editProf = new User_Edit_Profile();
            editProf.Show();
            this.Hide();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tbEmail.ReadOnly = false;
            tbUsername.ReadOnly = false;
            tbPhone.ReadOnly = false;
            tbPassword.ReadOnly = false;


            btnSave.Visible = true;
            btnEditProfile.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tbEmail.ReadOnly = true;
            tbUsername.ReadOnly = true;
            tbPhone.ReadOnly = true;
            tbPassword.ReadOnly = true;

            
            btnSave.Visible = false;
            btnEditProfile.Visible = true;
        }
    }
}