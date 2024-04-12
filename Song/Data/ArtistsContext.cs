using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Song.Models;

namespace Song.Data
{
    public class ArtistsContext : DbContext
    {
        public ArtistsContext (DbContextOptions<ArtistsContext> options)
            : base(options)
        {
        }

        public DbSet<Song.Models.Artists> Artists { get; set; } = default!;
    }
}
