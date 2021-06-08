using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMonster5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMonster5.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMonster5Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMonster5Context>>()))
            {
                // Look for any monsters.
                if (context.Monster.Any())
                {
                    return;   // DB has been seeded
                }

                context.Monster.AddRange(
                    new Monster
                    {
                        MonsterName = "Spider1",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Spiders",
                        Price = 7.99M,
                        Rating = "A"
                    },

                    new Monster
                    {
                        MonsterName = "Spider2",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Spiders",
                        Price = 8.99M,
                        Rating = "A"
                    },

                    new Monster
                    {
                        MonsterName = "Spider3",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Spiders",
                        Price = 9.99M,
                        Rating = "A"
                    },

                    new Monster
                    {
                        MonsterName = "Beetle1",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Bugs",
                        Price = 3.99M,
                        Rating = "A"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
