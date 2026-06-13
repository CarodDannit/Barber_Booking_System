using Barber_Booking_System_EF.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barber_Booking_System_EF
{
    public class Helper
    {
        public static BekasIceCreamDbContext _db = new BekasIceCreamDbContext(File.ReadAllText("connection.txt"));
    }
}
