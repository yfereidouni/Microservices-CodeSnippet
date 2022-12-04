using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data;

public static class PrepDb
{
    public static async Task SeedData(IServiceProvider serviceProvider)
    {
        using (var context = new AppDbContext(
             serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
        {
            if (!context.Platforms.Any())
            {
                Console.WriteLine("--> Seeding Data...");

                context.Platforms.AddRange(
                    new Platform() { Name = ".NET", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" }
                );
                await context.SaveChangesAsync();
            }
            else
            {
                Console.WriteLine("--> We already have data!");
            }
        }

    }
}
