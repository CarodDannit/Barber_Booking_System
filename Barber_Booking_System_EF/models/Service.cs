using System;
using System.Collections.Generic;

namespace Barber_Booking_System_EF.models;

public partial class Service
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ICollection<Barber> Barbers { get; set; } = new List<Barber>();
}
