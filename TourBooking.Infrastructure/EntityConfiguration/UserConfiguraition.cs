using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourBooking.Domain.Entities;

namespace TourBooking.Infrastructure.EntityConfiguration
{
    public class UserConfiguraition : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                 .HasData(new User { Id =1, FirstName = "Thomas" ,LastName="Hohe",AccessAllUser=true,Password="1234",Role="Admin",Username="user1",Token=""});
            builder
                 .HasData(new User { Id =2, FirstName = "Harrison", LastName= "Ashdown\r\n", AccessAllUser=true,Password="1234",Role="user",Username="user2",Token=""});
        }
    }
}
