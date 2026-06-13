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
    public partial class Barber_Signup_Page : Form
    {
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
    }
}
