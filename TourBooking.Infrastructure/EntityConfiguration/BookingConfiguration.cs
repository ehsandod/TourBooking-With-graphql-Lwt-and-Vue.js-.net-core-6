using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TourBooking.Domain.Entities;

namespace TourBooking.Infrastructure.EntityConfiguration
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder
            .Property(b => b.Name)
            .IsRequired();
            builder
            .Property(b => b.CreateDate)
            .IsRequired();
            builder
            .Property(b => b.Status)
            .IsRequired();
            builder.HasKey(sc => new { sc.PartyLeaderId });
            builder
                .HasOne(sc => sc.PartyLeader)
                .WithMany(s => s.Bookings)
                .HasForeignKey(sc => sc.PartyLeaderId);
            builder
                .HasData(new Booking { PartyLeaderId = Guid.Parse("a1697955-bdc0-49f0-a704-08da73299f8d"), BookingId = Guid.Parse("d2fc8dea-e40c-4b09-805c-b19c99891f24"),
                    Name = "Andreas" ,CreateDate= DateTime.Parse("2020-05-09 20:11:00.0000000"),Status=1,Price=1500,Currency=8 });         
            builder
                .HasData(new Booking { PartyLeaderId = Guid.Parse("fb96e887-6582-4e75-d4da-08da7343ecea"), BookingId = Guid.Parse("d2fc8dea-e40c-4b05-805c-b19c97891f24"), 
                    Name = "Darush" ,CreateDate= DateTime.Parse("1990-02-01 23:00:00.0000000"),Status=1,Price=1200,Currency=7 });         
            builder
                .HasData(new Booking { PartyLeaderId = Guid.Parse("d2fc8dea-e40c-4b09-805c-b19c99991f24"), BookingId = Guid.Parse("8ad8d11d-01e7-454d-a2c9-f4e94ea991cd"), 
                    Name = "Kiristin" ,CreateDate= DateTime.Parse("2020-05-09 20:11:00.0000000"),Status=1,Price=800,Currency=2 });         
        }
    }
}
