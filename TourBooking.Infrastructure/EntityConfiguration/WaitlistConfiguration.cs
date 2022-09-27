using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TourBooking.Domain.Entities;

namespace TourBooking.Infrastructure.EntityConfiguration
{
    public class WaitlistConfiguration : IEntityTypeConfiguration<Waitlist>
    {
        public void Configure(EntityTypeBuilder<Waitlist> builder)
        {
            //builder.HasNoKey();
            //builder.ToTable("waitlist");
            //builder.Property(e => e.Created).HasColumnName("created");
            //builder.Property(e => e.Firstname)
            //    .IsUnicode(false)
            //    .HasColumnName("firstname");
            //builder.Property(e => e.WaitlistId).HasColumnName("Waitlistid");
            //builder.Property(e => e.Lastname)
            //    .IsUnicode(false)
            //    .HasColumnName("lastname");
            //builder.Property(e => e.Listname)
            //    .IsUnicode(false)
            //    .HasColumnName("listname");
        }
    }
}
