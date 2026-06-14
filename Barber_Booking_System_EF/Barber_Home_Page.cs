using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Barber_Booking_System_EF.models;

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

        private void button2_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }
    }
}
