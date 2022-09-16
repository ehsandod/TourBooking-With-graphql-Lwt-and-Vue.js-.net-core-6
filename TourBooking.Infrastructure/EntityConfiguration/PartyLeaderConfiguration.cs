using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TourBooking.Domain.Entities;

namespace TourBooking.Infrastructure.EntityConfiguration
{
    public class PartyLeaderConfiguration : IEntityTypeConfiguration<PartyLeader>
    {
        public void Configure(EntityTypeBuilder<PartyLeader> builder)
        {
            builder
                .HasData(new PartyLeader { PartyLeaderId = Guid.Parse("a1697955-bdc0-49f0-a704-08da73299f8d"), Name = "MoreHami" });
            builder
                .HasData(new PartyLeader { PartyLeaderId = Guid.Parse("fb96e887-6582-4e75-d4da-08da7343ecea"), Name = "DigiKala" });
            builder
                .HasData(new PartyLeader { PartyLeaderId = Guid.Parse("d2fc8dea-e40c-4b09-805c-b19c99991f24"), Name = "AliBaba" });
            builder
                .HasData(new PartyLeader { PartyLeaderId = Guid.Parse("5b8a57ee-b147-4f8c-b7e6-f8725119deb4"), Name = "EliGasht" });
        }
    }
}
