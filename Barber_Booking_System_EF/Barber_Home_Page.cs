using Barber_Booking_System_EF.models;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
            // tab 1, Bookings
            dgvBookings.AutoGenerateColumns = false;
            dgvBarber.AutoGenerateColumns = false;
        }

        private async Task loadBooking()
        {
            var result = _db.Bookings
            .Where(bk => bk.BarberId == barber.Id)
            .Select(bk => new
            {
                bk.Id,
                cName = bk.Cust.Name,
                sName = bk.Service.Name,
                oLocation = bk.Outlet.Location,
                bk.Date,
                bk.Timeslot.Time,
                bk.Status
            })
            .ToList();
            foreach (var bk in result)
            {
                dgvBookings.Rows.Add(
                    bk.Id, bk.sName, bk.cName, bk.Date, bk.Time, bk.Status
                );
            }
        }

        private void loadBarber()
        {
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
            // Bookings tab
            lblBookingId.Text = "";
            lblService.Text = "";
            lblCustomer.Text = "";
            lblDate.Text = "";
            lblStatus.Text = "";
            await loadBooking();

            // Profile tab
            tbId.Text = barber.Id.ToString();
            tbName.Text = barber.Name;
            tbEmail.Text = barber.Email;
            tbPassword.Text = barber.Password;

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

            // get barber's pfp
            //   check if 0
            bool isZero = true;
            for (int x = 0; x < barber.Pfp.Length; x++)
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

            // tab Barber
            loadBarber();
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
            lblService.Text = row.Cells["sName"].Value?.ToString();
            lblCustomer.Text = row.Cells["cName"].Value?.ToString();
            lblDate.Text = row.Cells["Date"].Value.ToString();
            lblStatus.Text = row.Cells["Status"].Value?.ToString();

            if (lblStatus.Text == "Accepted")
            {
                btnCompleteBooking.Visible = true;
                btnRejectButton.Visible = false;
                btnAcceptBooking.Visible = false;
            }
            if (lblStatus.Text == "Rejected")
            {
                btnCompleteBooking.Visible = false;
                btnRejectButton.Visible = false;
                btnAcceptBooking.Visible = false;
            }
            if (lblStatus.Text == "Completed")
            {
                btnCompleteBooking.Visible = false;
                btnRejectButton.Visible = false;
                btnAcceptBooking.Visible = false;
            }
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBoxBarber.ImageLocation = openFileDialog.FileName;
            }

            openFileDialog.Dispose();
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

            // Read file bytes and convert to Base64 string
            var imageBytes = File.ReadAllBytes(pictureBoxBarber.ImageLocation);
            barber.Pfp = imageBytes;

            barber.OutletId = outlets[cbOutlet.SelectedIndex].Id;
            barber.Timeslots = timeslots.Where((t, index) => checkedListTimeSlot.GetItemChecked(index)).ToList();
            barber.Services = services.Where((s, index) => checkedListServices.GetItemChecked(index)).ToList();
            _db.SaveChanges();

            MessageBox.Show("Profile Updated!");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginpage = new Barber_Login_Page();
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

        private void label90_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            pieChart1.LegendPosition = LiveChartsCore.Measure.LegendPosition.Bottom;
            var series = new List<ISeries>();
            // select customer name and number of bookings made
            var source = _db.Customers.Select(c => new { c.Name, Count = c.Bookings.Count });
            foreach (var obj in source)
            {
                series.Add(new PieSeries<double>
                {
                    Values = new double[] { obj.Count },
                    Name = obj.Name,
                    ShowDataLabels = true

                    //DataLabels = true,
                    //LabelPoint = labelPoint
                });
            }
            pieChart1.Series = series;
            // ===========================================================
            // CHART1: GROUP BY NAMA SERVIS (KUNCI PENYELESAIAN)
            // ===========================================================
            chart1.Series.Clear();
            chart1.Titles.Clear();

            chart1.Titles.Add("Perbandingan Jenis Potongan (Kesemua Barber)");

            var seriesChart1 = chart1.Series.Add("Jumlah Tempahan");
            seriesChart1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            seriesChart1.IsXValueIndexed = true;
            seriesChart1.IsValueShownAsLabel = true;

            var chartData = _db.Bookings
                .Where(b => b.Service != null)
                .GroupBy(b => b.Service.Name)
                .Select(g => new
                {
                    ServiceName = g.Key,
                    TotalCount = g.Count()
                })
                .OrderByDescending(x => x.TotalCount)
                .ToList();

            foreach (var item in chartData)
            {
                seriesChart1.Points.AddXY(item.ServiceName, item.TotalCount);
            }
        }

        private void pieChart1_Load_1(object sender, EventArgs e)
        {

        }

        private void pieChart1_Load_2(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tbBarberId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBarberEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnDeleteBarber_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbBarberId.Text)) return;

            int barberId = int.Parse(tbBarberId.Text);

            var barber = _db.Barbers.Include(b => b.Services).FirstOrDefault(b => b.Id == barberId);



            if (barber == null)
            {
                MessageBox.Show("Barber not found");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this barber?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
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

        private void checkedListTimeSlot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAcceptBooking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblBookingId.Text))
            {
                MessageBox.Show("Please select a booking.");
                return;
            }

            int bookingId = Convert.ToInt32(lblBookingId.Text);

            var booking = _db.Bookings.FirstOrDefault(b => b.Id == bookingId);

            if (booking == null)
            {
                MessageBox.Show("Booking not found.");
                return;
            }

            if (booking.Status != "Pending")
            {
                MessageBox.Show("This booking has already been processed. Cannot be accepted anymore.");
                return;
            }

            booking.Status = "Accepted";

            _db.SaveChanges();

            MessageBox.Show("Booking accepted successfully!");

            loadBooking();

            lblStatus.Text = booking.Status;

        }

        private void btnRejectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblBookingId.Text))
            {
                MessageBox.Show("Please select a booking.");
                return;
            }

            int bookingId = Convert.ToInt32(lblBookingId.Text);

            var booking = _db.Bookings.FirstOrDefault(b => b.Id == bookingId);

            if (booking == null)
            {
                MessageBox.Show("Booking not found.");
                return;
            }

            if (booking.Status != "Pending")
            {
                MessageBox.Show("This booking has already been processed. Cannot be rejected anymore.");
                return;
            }

            booking.Status = "Rejected";

            _db.SaveChanges();

            MessageBox.Show("Booking rejected!");

            loadBooking();
            lblStatus.Text = booking.Status;
        }

        private void btnCompleteBooking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblBookingId.Text))
            {
                MessageBox.Show("Please select a booking.");
                return;
            }

            int bookingId = Convert.ToInt32(lblBookingId.Text);

            var booking = _db.Bookings.FirstOrDefault(b => b.Id == bookingId);

            if (booking == null)
            {
                MessageBox.Show("Booking not found.");
                return;
            }

            booking.Status = "Completed";

            _db.SaveChanges();

            MessageBox.Show("Booking completed successfully!");

            loadBooking();

            lblStatus.Text = booking.Status;
        }

        //REVENUE TAB
        private void loadMonthlyRevenue()
        {
            chartRevenue.Series.Clear();
            chartRevenue.Titles.Clear();

            chartRevenue.Titles.Add("Monthly Revenue");

            var series = chartRevenue.Series.Add("Revenue");
            series.ChartType = SeriesChartType.Column;
            series.Points.Clear();
            series.XValueType = ChartValueType.String;
            series.IsValueShownAsLabel = true;
            series.IsXValueIndexed = true;

            var revenue = _db.Bookings
                .Where(b => b.BarberId == barber.Id &&
                            b.Status == "Completed")
                .GroupBy(b => b.Date.Month)
                .Select(g => new
                {
                    Month = g.Key,
                    Revenue = g.Sum(x => x.Service.Price)
                })
                .OrderBy(x => x.Month)
                .ToList();

            decimal totalRevenue = revenue.Sum(x => x.Revenue);
            lblTotalRev.Text = $"RM {totalRevenue:N2}";

            decimal avgMonthlyRevenue = 0;

            if (revenue.Count > 0)
            {
                avgMonthlyRevenue = revenue.Average(x => x.Revenue);
            }

            lblAvgMonRev.Text = $"RM {avgMonthlyRevenue:N2}";

            if (revenue.Any())
            {
                var highest = revenue.OrderByDescending(x => x.Revenue).First();

                string monthName = new DateTime(2026, highest.Month, 1).ToString("MMMM");

                lblHighMonRev.Text = $"{monthName} (RM {highest.Revenue:N2})";
            }
            else
            {
                lblHighMonRev.Text = "No revenue";
            }

            foreach (var item in revenue)
            {
                series.Points.AddXY(
                    CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(item.Month),
                    item.Revenue);
            }

        }

        private void btnGenerateRevenue_Click(object sender, EventArgs e)
        {
            loadMonthlyRevenue();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblBookingId.Text))
            {
                MessageBox.Show("Please select a booking!");
                return;
            }

            int bookingId = int.Parse(lblBookingId.Text);
            var booking = _db.Bookings
                .Include(b => b.Barber)
                .Include(b => b.Outlet)
                .Include(b => b.Service)
                .Include(b => b.Timeslot)
                .Where(b => b.Id == bookingId)
                .FirstOrDefault();

            var viewdetailspage = new User_ViewBooking(booking);
            viewdetailspage.ShowDialog();
        }
    }
}
