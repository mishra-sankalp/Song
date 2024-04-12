using Microsoft.EntityFrameworkCore;
using Song.Data;

namespace Song.Models
{
    public class SeedDataAlbums
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AlbumsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AlbumsContext>>()))
            {
                // Look for any movies.
                if (context.Albums.Any())
                {
                    return;   // DB has been seeded
                }
                context.Albums.AddRange(
                    new Albums
                    {
                        Name = "shiv Kailashon ke vashi",
                        Artists = "Hansraj raghuvanshi"
                    },
                   new Albums
                   {
                       Name = "Sankalp kumar Mishra",
                       Artists = "shiv Kailashon ke vashi"
                   },
                   new Albums
                   {
                       Name = "Sankalp kumar Mishra",
                       Artists = "shiv Kailashon ke vashi"
                   }
                );
                context.SaveChanges();
            }
        }
    }
}