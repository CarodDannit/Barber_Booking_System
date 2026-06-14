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


        private static void CreateBooking()
        {
            var newBooking = new Booking()
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                Description = "",
                CustId = 1,
                OutletId = 1,
                BarberId = 5,
                ServiceId = 1,
                TimeslotId = 1,
                Status = "otw"
            };

            _db.Add(newBooking);
            _db.SaveChanges();
        }

        private static void FindUpdateBooking()
        {
            var bookingFromDB = _db.Bookings.FirstOrDefault(b => b.Id == 1);
            if (bookingFromDB == null)
            {
                // booking not found!
                return;
            }

            // use bookingFromDB
            // maybe edit bookingFromDB
            bookingFromDB.Status = "Complete";
            _db.SaveChanges();
        }
    }
}
