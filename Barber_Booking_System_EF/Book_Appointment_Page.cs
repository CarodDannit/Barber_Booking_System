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
    public partial class Book_Appointment_Page : Form
    {
        BekasIceCreamDbContext _db = Helper._db;
        List<Outlet> outlets;
        Outlet selectedOutlet;
        List<Barber> barbers;
        Barber selectedBarber;
        List<Service> services;


        Customer customer;
        public Book_Appointment_Page(Customer c)
        {
            InitializeComponent();
            customer = c;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void Book_Appointment_Page_Load(object sender, EventArgs e)
        {
            outlets = await _db.Outlets.ToListAsync();

            cbOutlet.Items.Clear();
            foreach (var o in outlets)
            {
                cbOutlet.Items.Add(o.Location);
            }
        }

        private async void cbOutlet_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedOutlet = outlets[cbOutlet.SelectedIndex];

            barbers = await _db.Barbers
                .Where(b => b.OutletId == selectedOutlet.Id)
                .ToListAsync();

            cbBarber.Items.Clear();
            foreach (var b in barbers)
            {
                cbBarber.Items.Add(b.Name);
            }

            cbBarber.Enabled = true;
            cbService.Enabled = false;
        }

        private void cbBarber_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBarber = barbers[cbBarber.SelectedIndex];

            services =
        }
    }
}
