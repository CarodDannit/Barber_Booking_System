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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Barber_Booking_System_EF
{
    public partial class Barber_Signup_Page : Form
    {
        BekasIceCreamDbContext _db = Helper._db;
        List<Service> services;
        List<Outlet> outlets;
        public Barber_Signup_Page()
        {
            InitializeComponent();
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            // openFileDialog W.I.P.
            openFileDialog1.Filter = "image sikit2 je WIP (*.jpg; *.jpeg)|*.jpg; *.jpeg";
            //openFileDialog1.ShowDialog();


            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBoxBarber.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            string gender;

            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {   
                MessageBox.Show("Email cannot be empty!");
                return;
            } 
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                MessageBox.Show("Name cannot be empty!");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Password cannot be empty!");
                return; 
            }
            if(!rdMale.Checked && !rdFemale.Checked)
            {
                MessageBox.Show("Please Pick Gender la!");
                return;
            }
            else{
                if (rdMale.Checked) gender = "M";
                else gender = "F";
            }
            if (cbOutlet.SelectedIndex == -1){
                MessageBox.Show("Please Pick Outlet la!");
                return;
            }

            var selectedOutlet = outlets[cbOutlet.SelectedIndex];

            var selectedServices = new List<Service>();
            foreach (var s in checkListService.CheckedItems)
            {
                var service = services.FirstOrDefault(serv => serv.Name == s.ToString());
                if (service != null) selectedServices.Add(service);
            }

            var newBarber = new Barber()
            {
                Email = tbEmail.Text,
                Name = tbName.Text,
                Password = tbPassword.Text,
                Gender = gender,
                Pfp = new byte[0], // WIP
                OutletId = selectedOutlet.Id,
                Services = selectedServices
            };
            MessageBox.Show(newBarber.Id.ToString());
            Helper._db.Add(newBarber);
            Helper._db.SaveChanges();

            
        }

        private async void Barber_Signup_Page_Load(object sender, EventArgs e)
        {
            services = await _db.Services.ToListAsync();
            foreach (var s in services)
            {
                checkListService.Items.Add(s.Name);
            }

            outlets = await _db.Outlets.ToListAsync();
            foreach (var o in outlets)
            {
                cbOutlet.Items.Add(o.Location);
            }

        }
    }
}
