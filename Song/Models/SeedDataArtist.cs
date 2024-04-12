using Microsoft.EntityFrameworkCore;
using Song.Data;

namespace Song.Models
{
    public class SeedDataArtist
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ArtistsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ArtistsContext>>()))
            {
                // Look for any movies.
                if (context.Artists.Any())
                {
                    return;   // DB has been seeded
                }
                context.Artists.AddRange(
                    new Artists
                    {
                        Name = "Sankalp kumar Mishra",
                        albums="shiv Kailashon ke vashi"
                    },
                    new Artists
                    {
                        Name = "Sankalp kumar Mishra",
                        albums = "shiv Kailashon ke vashi"
                    },
                    new Artists
                    {
                        Name = "Sankalp kumar Mishra",
                        albums = "shiv Kailashon ke vashi"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}