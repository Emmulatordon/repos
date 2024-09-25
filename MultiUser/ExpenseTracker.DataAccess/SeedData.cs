
using ExpenseTracker.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
namespace ExpenseTracker.DataAccess
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Habit>().HasData(
                new Habit { Id = 1, Name = "Learn French", Description = "Become a francophone", TenantName = "Bluewave" },
                new Habit { Id = 2, Name = "Run a marathon", Description = "Get really fit", TenantName = "AscendTech" },
                new Habit { Id = 3, Name = "Write every day", Description = "Finish your book project", TenantName = "CloudSphere" },
                new Habit { Id = 4, Name = "Write every day", Description = "Finish your book project", TenantName = "DataStream" }
            );
        }
    }
}
