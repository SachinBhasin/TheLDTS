using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheLDTS.Models;

namespace TheLDTS.Data
{
    public class TheLDTSContext : DbContext
    {
        public TheLDTSContext (DbContextOptions<TheLDTSContext> options)
            : base(options)
        {
        }

        public DbSet<TheLDTS.Models.Landlord> Landlord { get; set; } = default!;

        public DbSet<TheLDTS.Models.Property>? Property { get; set; }
    }
}
