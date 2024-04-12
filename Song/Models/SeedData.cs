using Microsoft.EntityFrameworkCore;
using Song.Data;

namespace Song.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UsersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UsersContext>>()))
            {
                // Look for any movies.
                if (context.Users.Any())
                {
                    return;   // DB has been seeded
                }
                context.Users.AddRange(
                    new Users
                    {
                        Name = "Sankalp kumar Mishra",
                        dob = DateTime.Parse("1989-2-12"),
                        Email = "sankalp22int@gmail.com",
                        gender = "M"
                    },
                    new Users
                    {
                        Name = "Sankalp kumar Mishra",
                        dob = DateTime.Parse("1989-2-12"),
                        Email = "sankalp22int@gmail.com",
                        gender = "M"
                    },
                   new Users
                   {
                       Name = "Sankalp kumar Mishra",
                       dob = DateTime.Parse("1989-2-12"),
                       Email = "sankalp22int@gmail.com",
                       gender = "M"
                   },
                  new Users
                  {
                      Name = "Sankalp kumar Mishra",
                      dob = DateTime.Parse("1989-2-12"),
                      Email = "sankalp22int@gmail.com",
                      gender = "M"
                  }
                );
                context.SaveChanges();
            }
        }
    }
}