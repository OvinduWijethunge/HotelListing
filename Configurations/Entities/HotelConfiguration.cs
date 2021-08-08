using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Cinnomon",
                    Address = "Colombo",
                    CountryId = 1,
                    
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Jetwing",
                    Address = "Galle",
                    CountryId = 1,
                    
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Mou - Mou",
                    Address = "Kolkata",
                    CountryId = 2,
                    
                }
            );
        }

        
    }
}
