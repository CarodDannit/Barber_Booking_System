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
        List<Outlet>? outlets;
        Outlet? selectedOutlet;
        List<Barber>? barbers;
        Barber? selectedBarber;
        List<Service>? services;
        Service? selectedService;
        List<Timeslot>? timeslots;
        Timeslot? selectedTimeslot;


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

            // get outlet's barbers
            barbers = await _db.Barbers
                .Where(b => b.OutletId == selectedOutlet.Id)
                .ToListAsync();

            //   if no barbers found

            cbBarber.Items.Clear();
            cbBarber.Text = null;
            foreach (var b in barbers)
            {
                cbBarber.Items.Add(b.Name);
            }

            cbBarber.Enabled = true;

            cbService.Items.Clear();
            cbService.Text = null;
            cbService.Enabled = false;

            cbTimeslot.Items.Clear();
            cbTimeslot.Text = null;
            cbTimeslot.Enabled = false;
        }

        private async void cbBarber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBarber.SelectedIndex < 0 || barbers == null) return;

            selectedBarber = barbers[cbBarber.SelectedIndex];

            // get barber's services
            services = _db.Barbers
                .Where(b => b.Id == selectedBarber.Id)
                .Select(b => b.Services)
                .FirstOrDefault()?
                .ToList();

            //   if no services found
            if (services == null || services.Count == 0)
            {
                MessageBox.Show("Barber does not offer any services!");
                return;
            }

            //   populate cbService
            cbService.Items.Clear();
            cbService.Text = null;
            foreach (var s in services)
            {
                cbService.Items.Add(s.Name);
            }
            cbService.Enabled = true;

            // get barber's timeslots (hard-coded temporarily)
            //timeslots = _db.Barbers
            //    .Where(b => b.Id == selectedBarber.Id)
            //    .Select(b => b.Timeslots)
            //    .FirstOrDefault()?
            //    .ToList();
            if (timeslots == null)
                timeslots = _db.Timeslots.ToList();

            //   if no timeslots found
            if (timeslots == null || timeslots.Count == 0)
            {
                MessageBox.Show("Barber has no schedule!");
                return;
            }

            //   populate cbTimeslots
            cbTimeslot.Items.Clear();
            cbTimeslot.Text = null;
            foreach (var t in timeslots)
            {
                cbTimeslot.Items.Add(t.Time.ToLongTimeString());
            }
            cbTimeslot.Enabled = true;
        }

        private void cbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbService.SelectedIndex < 0 || services == null) return;

            selectedService = services[cbService.SelectedIndex];
        }

        private void cbTimeslot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTimeslot.SelectedIndex < 0 || timeslots == null) return;

            selectedTimeslot = timeslots[cbTimeslot.SelectedIndex];
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            // validation
            if (calendar.SelectionStart < DateTime.Today)
            {
                MessageBox.Show("Cannot book before today!");
                return;
            }
            if (cbOutlet.SelectedIndex < 0)
            {
                MessageBox.Show("Select an outlet!");
                return;
            }
            if (cbBarber.SelectedIndex < 0)
            {
                MessageBox.Show("Select a barber!");
                return;
            }
            if (cbService.SelectedIndex < 0)
            {
                MessageBox.Show("Select a service!");
                return;
            }
            if (cbTimeslot.SelectedIndex < 0)
            {
                MessageBox.Show("Select a time slot!");
                return;
            }

            var newBooking = new Booking()
            {
                Date = DateOnly.FromDateTime(calendar.SelectionStart),
                CustId = customer.Id,
                OutletId = selectedOutlet.Id,
                BarberId = selectedBarber.Id,
                ServiceId = selectedService.Id,
                TimeslotId = selectedTimeslot.Id,
                Status = "Pending"
            };

            _db.Add(newBooking);
            _db.SaveChanges();

            MessageBox.Show("Booked successfully! Maybe close this form.");
        }
    }
}
