using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Song.Models;

namespace Song.Data
{
    public class AlbumsContext : DbContext
    {
        public AlbumsContext (DbContextOptions<AlbumsContext> options)
            : base(options)
        {
        }

        public DbSet<Song.Models.Albums> Albums { get; set; } = default!;
    }
}
