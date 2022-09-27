using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TourBooking.Domain.Entities;

namespace TourBooking.Infrastructure.EntityConfiguration
{
    public class StationConfiguration: IEntityTypeConfiguration<Station>
    {
        public void Configure(EntityTypeBuilder<Station> builder)
        {
            //builder.HasNoKey();
            //builder.Property(e => e.City)
            //    .HasMaxLength(21)
            //    .IsUnicode(false)
            //    .HasColumnName("city");
            //builder.Property(e => e.StationId).HasColumnName("StationId");
            //builder.Property(e => e.LatN).HasColumnName("lat_n");
            //builder.Property(e => e.LongW).HasColumnName("long_w");
            //builder.Property(e => e.State)
            //            .HasMaxLength(2)
            //            .IsUnicode(false)
            //            .HasColumnName("state");
        }
    }
}
