using System;
using System.Collections.Generic;

namespace Barber_Booking_System_X.models;

public partial class Booking
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public string? Description { get; set; }

    public int CustId { get; set; }

    public int OutletId { get; set; }

    public int BarberId { get; set; }

    public int ServiceId { get; set; }

    public int TimeslotId { get; set; }

    public string Status { get; set; } = null!;

    public decimal? Rating { get; set; }

    public string? Review { get; set; }

    public virtual Barber Barber { get; set; } = null!;

    public virtual Customer Cust { get; set; } = null!;

    public virtual Outlet Outlet { get; set; } = null!;

    public virtual Service Service { get; set; } = null!;

    public virtual Timeslot Timeslot { get; set; } = null!;
}
