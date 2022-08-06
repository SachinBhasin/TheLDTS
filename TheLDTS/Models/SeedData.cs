using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TheLDTS.Data;
using System;
using System.Linq;

namespace TheLDTS.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TheLDTSContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TheLDTSContext>>()))
            {
                // Look for any movies.
                if (context.Landlord.Any())
                {
                    return;   // DB has been seeded
                }
                context.Landlord.AddRange(
                    new Landlord
                    {
                        FirstName = "Harry",
                    },

                    new Landlord
                    {
                        FirstName = "Sally",
                    },

                    new Landlord
                    {
                        FirstName = "Garry",
                    },

                    new Landlord
                    {
                        FirstName = "Rio",
                    }
                );
                context.SaveChanges();

                context.Property.AddRange(
                    new Property
                    {
                        LandlordID = 1,
                        HouseNumber = 1,
                    },

                    new Property
                    {
                        LandlordID = 2,
                        HouseNumber = 2,
                    },

                    new Property
                    {
                        LandlordID = 3,
                        HouseNumber = 3,
                    },

                    new Property
                    {
                        LandlordID = 4,
                        HouseNumber = 4,
                    }
                );
                context.SaveChanges();


            }
        }
    }
}
