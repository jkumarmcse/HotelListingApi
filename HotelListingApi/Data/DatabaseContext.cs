using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingApi.Data
{
    public class DatabaseContext :DbContext
    {
        public DatabaseContext(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    ShortName = "In"

                },
                             new Country
                             {
                                 Id = 2,
                                 Name = "Bahamas",
                                 ShortName = "Bs"

                             },
                                          new Country
                                          {
                                              Id = 3,
                                              Name = "Cayman Island",
                                              ShortName = "CI"

                                          }
                );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {

                    Id = 1,
                    Name = "Sandals Resort and SPA",
                    Address = "NegrilIn",
                    CountryId = 1,
                    Rating = 4.5


                },
                new Hotel
                {

                    Id = 2,
                    Name = "Comfor Switeches",
                    Address = "Nassua",
                    CountryId = 2,
                    Rating = 4.2


                },
                new Hotel
                {

                    Id = 3,
                    Name = " Resort and SPA",
                    Address = "Tamil Nadu",
                    CountryId = 3,
                    Rating = 4


                }
                           );

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }




    }
}
