using Deloitte_Training_Center.Data;
using Microsoft.EntityFrameworkCore;

namespace Deloitte_Training_Center.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Deloitte_Training_CenterContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Deloitte_Training_CenterContext>>()))
            {
                // Look for any movies.
                if (context.Training.Any())
                {
                    return;   // DB has been seeded
                }
                context.Training.AddRange(
                    new Training
                    {
                        name = "Java Bootcamp",
                        dateTime = DateTime.Parse("2023-11-06"),
                        prequisite = "N/A",
                        duration = TimeSpan.Parse("03:00:00.0000"),
                        credit = 3.25M
                    },
                    new Training
                    {
                        name = "Frontend skills training",
                        dateTime = DateTime.Parse("2024-01-15"),
                        prequisite = "HTML,CSS,JS course",
                        duration = TimeSpan.Parse("05:00:00.0000"),
                        credit = 5.00M
                    },
                    new Training
                    {
                        name = ".Net Onboarding",
                        dateTime = DateTime.Parse("2024-11-04"),
                        prequisite = "N/A",
                        duration = TimeSpan.Parse("08:00:00.0000"),
                        credit = 40.00M
                    },
                    new Training
                    {
                        name = "Spark GPS Onboarding",
                        dateTime = DateTime.Parse("2024-10-16"),
                        prequisite = "DLaunch",
                        duration = TimeSpan.Parse("18:00:00.0000"),
                        credit = 18.5M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
