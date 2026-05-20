using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Barber_Booking_System_X.models;

public partial class BekasIceCreamContext : DbContext
{
    public BekasIceCreamContext()
    {
    }

    public BekasIceCreamContext(DbContextOptions<BekasIceCreamContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Barber> Barbers { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Outlet> Outlets { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Timeslot> Timeslots { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\MADLY\\DESKTOP\\UTEMMING\\EDP\\BARBER_BOOKING_SYSTEM\\BARBER_BOOKING_SYSTEM_X\\BEKASICECREAM_X.MDF;Integrated Security=True");
    // AttachDbFilename=|DataDirectory|\\BekasIceCream_X.mdf
    // Initial Catalog=C:\\USERS\\MADLY\\DESKTOP\\UTEMMING\\EDP\\BARBER_BOOKING_SYSTEM\\BARBER_BOOKING_SYSTEM_X\\BEKASICECREAM_X.MDF

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Barber>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BARBER__3214EC070FB43EB0");

            entity.ToTable("BARBER");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(6);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.OutletId).HasColumnName("Outlet_Id");
            entity.Property(e => e.Password).HasMaxLength(20);

            entity.HasOne(d => d.Outlet).WithMany(p => p.Barbers)
                .HasForeignKey(d => d.OutletId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BARBER_ToOutlet");

            entity.HasMany(d => d.Services).WithMany(p => p.Barbers)
                .UsingEntity<Dictionary<string, object>>(
                    "BarberService",
                    r => r.HasOne<Service>().WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_BARBER_SERVICE_ToSERVICE"),
                    l => l.HasOne<Barber>().WithMany()
                        .HasForeignKey("BarberId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_BARBER_SERVICE_ToBARBER"),
                    j =>
                    {
                        j.HasKey("BarberId", "ServiceId");
                        j.ToTable("BARBER_SERVICE");
                        j.IndexerProperty<int>("BarberId").HasColumnName("Barber_Id");
                        j.IndexerProperty<int>("ServiceId").HasColumnName("Service_Id");
                    });

            entity.HasMany(d => d.Timeslots).WithMany(p => p.Barbers)
                .UsingEntity<Dictionary<string, object>>(
                    "Schedule",
                    r => r.HasOne<Timeslot>().WithMany()
                        .HasForeignKey("TimeslotId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SCHEDULE_ToTIMESLOT"),
                    l => l.HasOne<Barber>().WithMany()
                        .HasForeignKey("BarberId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SCHEDULE_ToBARBER"),
                    j =>
                    {
                        j.HasKey("BarberId", "TimeslotId");
                        j.ToTable("SCHEDULE");
                        j.IndexerProperty<int>("BarberId").HasColumnName("Barber_Id");
                        j.IndexerProperty<int>("TimeslotId").HasColumnName("Timeslot_Id");
                    });
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BOOKING__3214EC07F306198B");

            entity.ToTable("BOOKING");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.BarberId).HasColumnName("Barber_Id");
            entity.Property(e => e.CustId).HasColumnName("Cust_Id");
            entity.Property(e => e.OutletId).HasColumnName("Outlet_Id");
            entity.Property(e => e.Rating).HasColumnType("decimal(2, 1)");
            entity.Property(e => e.ServiceId).HasColumnName("Service_Id");
            entity.Property(e => e.Status).HasMaxLength(15);
            entity.Property(e => e.TimeslotId).HasColumnName("Timeslot_Id");

            entity.HasOne(d => d.Barber).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.BarberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOOKING_ToBARBER");

            entity.HasOne(d => d.Cust).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.CustId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOOKING_ToCUSTOMER");

            entity.HasOne(d => d.Outlet).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.OutletId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOOKING_ToOUTLET");

            entity.HasOne(d => d.Service).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOOKING_ToSERVICE");

            entity.HasOne(d => d.Timeslot).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.TimeslotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BOOKING_ToTIMESLOT");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC079932BFAC");

            entity.ToTable("CUSTOMER");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(20);
        });

        modelBuilder.Entity<Outlet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OUTLET__3214EC07AE0493BA");

            entity.ToTable("OUTLET");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Location).HasMaxLength(50);
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SERVICE__3214EC075EFD5E49");

            entity.ToTable("SERVICE");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Timeslot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TIMESLOT__3214EC07D5413384");

            entity.ToTable("TIMESLOT");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Time).HasPrecision(0);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
