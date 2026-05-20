using System;
using System.Collections.Generic;

namespace Barber_Booking_System_X.models;

public partial class Outlet
{
    public int Id { get; set; }

    public string Location { get; set; } = null!;

    public byte[] Image { get; set; } = null!;

    public virtual ICollection<Barber> Barbers { get; set; } = new List<Barber>();

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
