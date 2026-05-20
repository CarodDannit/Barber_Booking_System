using System;
using System.Collections.Generic;

namespace Barber_Booking_System_X.models;

public partial class Timeslot
{
    public int Id { get; set; }

    public TimeOnly Time { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<Barber> Barbers { get; set; } = new List<Barber>();
}
