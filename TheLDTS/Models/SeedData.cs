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
                if (context.Landlord.Any())
                {
                    return;
                }
                context.Landlord.AddRange(
                    new Landlord
                    {
                        FirstName = "Rachelle",
                        LastName = "Imogen",
                        Email = "Rachelle@Imogen.com",
                        PhoneNumber = "07700900271",
                        Password = "k3enRoll18",
                    },

                    new Landlord
                    {
                        FirstName = "Anton",
                        LastName = "Stewart",
                        Email = "Anton@Stewart.com",
                        PhoneNumber = "01174960619",
                        Password = "gr3atLynx68",
                    },

                    new Landlord
                    {
                        FirstName = "Cleo",
                        LastName = "Authur",
                        Email = "Cleo@Authur.com",
                        PhoneNumber = "01184960486",
                        Password = "4mberBull75",
                    },

                    new Landlord
                    {
                        FirstName = "Juliana",
                        LastName = "Nicole",
                        Email = "Juliana@Nicole.com",
                        PhoneNumber = "01514960551",
                        Password = "sup3rPuppy70",
                    },
                    new Landlord
                    {
                        FirstName = "Alexander",
                        LastName = "Chapman",
                        Email = "Alexander@Chapman.com",
                        PhoneNumber = "01144960537",
                        Password = "8igWhit3D0g46",
                    }
                );
                context.SaveChanges();

                context.Property.AddRange(
                    new Property
                    {
                        LandlordID = 1,
                        HouseNumber = 35,
                        StreetName = "Greenwood Close",
                        City = "Sheffield",
                        Country = "United Kingdom",
                        Type = "Bungalow",
                        Rent = 19500,
                        Available = true,
                        CP12 = DateTime.Parse("2004-08-29"),
                        PAT = DateTime.Parse("2013-03-02"),
                        EICR = DateTime.Parse("2015-04-30"),
                        EPC = DateTime.Parse("2017-07-25"),
                        LegionellaTest = DateTime.Parse("2020-01-20"),
                    },

                    new Property
                    {
                        LandlordID = 2,
                        HouseNumber = 24,
                        StreetName = "Newport Road",
                        City = "Cambridge",
                        Country = "United Kingdom",
                        Type = "Apartment",
                        Rent = 760,
                        Available = true,
                        CP12 = DateTime.Parse("2002-04-04"),
                        PAT = DateTime.Parse("2003-06-18"),
                        EICR = DateTime.Parse("2007-08-07"),
                        EPC = DateTime.Parse("2008-12-24"),
                        LegionellaTest = DateTime.Parse("2013-04-23"),
                    },

                    new Property
                    {
                        LandlordID = 2,
                        HouseNumber = 52,
                        StreetName = "Windsor Avenue",
                        City = "London",
                        Country = "United Kingdom",
                        Type = "Flat",
                        Rent = 1500,
                        Available = true,
                        CP12 = DateTime.Parse("2009-03-03"),
                        PAT = DateTime.Parse("2009-04-05"),
                        EICR = DateTime.Parse("2012-05-17"),
                        EPC = DateTime.Parse("2017-06-01"),
                        LegionellaTest = DateTime.Parse("2019-12-12"),
                    },

                    new Property
                    {
                        LandlordID = 3,
                        HouseNumber = 27,
                        StreetName = "Manor Lane",
                        City = "York",
                        Country = "United Kingdom",
                        Type = "Mansion",
                        Rent = 127500,
                        Available = false,
                        CP12 = DateTime.Parse("2004-08-19"),
                        PAT = DateTime.Parse("2009-02-09"),
                        EICR = DateTime.Parse("2009-10-04"),
                        EPC = DateTime.Parse("2013-01-26"),
                        LegionellaTest = DateTime.Parse("2016-11-10"),
                    },
                    new Property
                    {
                        LandlordID = 1,
                        HouseNumber = 82,
                        StreetName = "Woodstock Road",
                        City = "Glasgow",
                        Country = "United Kingdom",
                        Type = "Cottage",
                        Rent = 759,
                        Available = true,
                        CP12 = DateTime.Parse("2000-08-11"),
                        PAT = DateTime.Parse("2007-03-18"),
                        EICR = DateTime.Parse("2007-04-24"),
                        EPC = DateTime.Parse("2009-04-04"),
                        LegionellaTest = DateTime.Parse("2021-01-26"),
                    }
                );
                context.SaveChanges();


            }
        }
    }
}
