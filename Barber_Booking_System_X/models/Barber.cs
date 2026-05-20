using System;
using System.Collections.Generic;

namespace Barber_Booking_System_X.models;

public partial class Barber
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public byte[] Pfp { get; set; } = null!;

    public int OutletId { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual Outlet Outlet { get; set; } = null!;

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();

    public virtual ICollection<Timeslot> Timeslots { get; set; } = new List<Timeslot>();
}
