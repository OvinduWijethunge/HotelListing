using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Country>().HasData(
                   new Country
                   { 
                       Id = 1,
                       Name = "India",
                       ShortName = "IN"
                   },
                   new Country
                   {
                       Id = 2,
                       Name = "Sri Lanka",
                       ShortName = "SL"

                   },
                   new Country
                   {
                       Id = 3,
                       Name = "England",
                       ShortName = "UK"

                   }
                );

            builder.Entity<Hotel>().HasData(
                   new Hotel
                   {
                       Id = 1,
                       Name = "Cinnomon",
                       Address = "Colombo 7",
                       CountryId = 1
                   },
                   new Hotel
                   {
                       Id = 2,
                       Name = "Jetwing",
                       Address = "Galle",
                       CountryId = 1

                   },
                   new Hotel
                   {
                       Id = 3,
                       Name = "Moumita",
                       Address = "Kolkata",
                       CountryId = 2

                   },
                   new Hotel
                   {
                       Id = 4,
                       Name = "Royal DD",
                       Address = "London",
                       CountryId = 3

                   }
                );

        }
    }
}
