using Barber_Booking_System_EF.models;
using Barber_Booking_System_EF.models;
using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Barber_Booking_System_EF
{
    public partial class Barber_Home_Page : Form
    {
        BekasIceCreamDbContext _db = Helper._db;
        Barber barber;
        List<Outlet> outlets;
        List<Timeslot> timeslots;
        List<Timeslot> timeslotsActive;
        List<Service> services;
        List<Service> servicesActive;

        public Barber_Home_Page(Barber b)
        {
            InitializeComponent();
            barber = b;

        }

        private void loadBooking()
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
        }

        private void loadBarber()
        {

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

        private async void Barber_Home_Page_Load(object sender, EventArgs e)
        {
            tbId.Text = barber.Id.ToString();
            tbName.Text = barber.Name.ToString();
            tbEmail.Text = barber.Email.ToString();
            tbPassword.Text = barber.Password.ToString();

            if (barber.Gender == "M") rbMale.Checked = true;
            else rbFemale.Checked = true;

            outlets = await _db.Outlets.ToListAsync();
            foreach (var o in outlets)
            {
                cbOutlet.Items.Add(o.Location);
            }
            var i = outlets.FindIndex(o => o.Id == barber.OutletId);
            cbOutlet.SelectedIndex = i;

            timeslots = await _db.Timeslots.Include(t => t.Barbers).ToListAsync();
            foreach (var t in timeslots)
            {
                checkedListTimeSlot.Items.Add(t.Time.ToLongTimeString());
            }

            timeslotsActive = timeslots.Where(t => t.Barbers.Any(b => b.Id == barber.Id)).ToList();
            foreach (var tA in timeslotsActive)
            {
                var index = timeslots.FindIndex(ts => ts.Id == tA.Id);
                if (index != -1) checkedListTimeSlot.SetItemChecked(index, true);
            }

            services = await _db.Services.Include(s => s.Barbers).ToListAsync();
            foreach (var s in services)
            {
                checkedListServices.Items.Add(s.Name);
            }

            servicesActive = services.Where(s => s.Barbers.Any(b => b.Id == barber.Id)).ToList();
            foreach (var sA in servicesActive)
            {
                var index = services.FindIndex(ts => ts.Id == sA.Id);
                if (index != -1) checkedListServices.SetItemChecked(index, true);
            }

            //try
            //{
            
            //}
            //catch
            //{
            //}

        

        // get barber's pfp
        //   check if 0
            bool isZero = true;
            for (int x = 0; x<barber.Pfp.Length; x++)
            {
                if (barber.Pfp[x] != 0)
                {
                    isZero = false;
                    break; // Stop immediately upon finding a non-zero byte
                }
            }
            //   read pfp
            if (!isZero)
            {
                var ms = new MemoryStream(barber.Pfp);
                pictureBoxBarber.Image = new Bitmap(ms);
                ms.Dispose();
            }
            else
            {
                pictureBoxBarber.Image = Properties.Resources.rukia04;
            }

            loadBarber();
            loadBooking();
        }

        private void btnAddBarber_Click(object sender, EventArgs e)
        {
            var bbS = new Barber_Signup_Page();
            this.Hide();
            var resultSignUp = bbS.ShowDialog();
            if (resultSignUp == DialogResult.OK)
                loadBarber();

            this.Show();
            bbS.Close();
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Name cannot be empty!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Email cannot be empty!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Password cannot be empty!");
                return;
            }


            barber.Name = tbName.Text;
            barber.Email = tbEmail.Text;
            barber.Password = tbPassword.Text;
            barber.Gender = rbMale.Checked ? "M" : "F";
            barber.OutletId = outlets[cbOutlet.SelectedIndex].Id;
            // pfp save
            barber.Timeslots = timeslots.Where((t, index) => checkedListTimeSlot.GetItemChecked(index)).ToList();
            barber.Services = services.Where((s, index) => checkedListServices.GetItemChecked(index)).ToList();
            _db.SaveChanges();

            MessageBox.Show("Profile Updated!");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginpage = new User_Login_Page();
            this.Hide();
            loginpage.ShowDialog();
            this.Close();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "image sikit2 je WIP (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBoxBarber.ImageLocation = openFileDialog.FileName;

                // Read file bytes and convert to Base64 string
                var imageBytes = File.ReadAllBytes(openFileDialog.FileName);

                barber.Pfp = imageBytes;
            }

            openFileDialog.Dispose();
        }

        private void btnDeleteBarber_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbBarberId.Text)) return;

            int barberId = int.Parse(tbBarberId.Text);

            var barber = _db.Barbers.Include(b=>b.Services).FirstOrDefault(b => b.Id == barberId);

            

            if(barber == null)
            {
                MessageBox.Show("Barber not found");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this barber?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                barber.Services.Clear();
                _db.Remove(barber);
                _db.SaveChanges();
                MessageBox.Show("Barber deleted successfully");


                loadBarber();
                tbBarberId.Text = "";
                tbBarberName.Text = "";
                tbBarberEmail.Text = "";
                tbBarberGender.Text = "";
                tbBarberOutlet.Text = "";
            }
        }
    }
}
