using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barber_Booking_System
{
    public partial class User_Home_Page : Form
    {
        public User_Home_Page()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bekasIceCream.BOOKING' table. You can move, or remove it, as needed.
            this.bOOKINGTableAdapter.Fill(this.bekasIceCream.BOOKING);
            // TODO: This line of code loads data into the 'bekasIceCream.BARBER' table. You can move, or remove it, as needed.
            this.bARBERTableAdapter.Fill(this.bekasIceCream.BARBER);
            // TODO: This line of code loads data into the 'bekasIceCream.BARBER' table. You can move, or remove it, as needed.
            this.bARBERTableAdapter.Fill(this.bekasIceCream.BARBER);
            Console.WriteLine("load hometyrtyrtyrtyrt page");
        }

        private void bARBERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bARBERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bekasIceCream);

        }

        private void bARBERBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bARBERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bekasIceCream);

        }

        private void bOOKINGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bOOKINGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bekasIceCream);

        }
    }
}
