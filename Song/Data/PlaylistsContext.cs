using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Song.Models;

namespace Song.Data
{
    public class PlaylistsContext : DbContext
    {
        public PlaylistsContext (DbContextOptions<PlaylistsContext> options)
            : base(options)
        {
        }

        public DbSet<Song.Models.Playlists> Playlists { get; set; } = default!;
    }
}
