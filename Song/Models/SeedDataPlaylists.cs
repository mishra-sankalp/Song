using Microsoft.EntityFrameworkCore;
using Song.Data;

namespace Song.Models
{
    public class SeedDataPlaylists
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PlaylistsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PlaylistsContext>>()))
            {
                // Look for any movies.
                if (context.Playlists.Any())
                {
                    return;   // DB has been seeded
                }
                context.Playlists.AddRange(
                    new Playlists
                    {
                        Name = "Mahadev",
                        Songs = "shiv Kailashon ke vashi"
                    },
                  new Playlists
                  {
                      Name = "Mahadev",
                      Songs = "shiv Kailashon ke vashi"
                  },
                  new Playlists
                  {
                      Name = "Mahadev",
                      Songs = "shiv Kailashon ke vashi"
                  }
                );
                context.SaveChanges();
            }
        }
    }
}