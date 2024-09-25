using ExpenseTracker.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExpenseTracker.Core
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAndMigrateDatabases(this IServiceCollection services, IConfiguration config)
        {
            var options = services.GetOptions<TenantSettings>(nameof(TenantSettings),config);
            var defaultConnectionString = options.DefaultConnectionString;
            services.AddDbContext<GoodHabitsDbContext>(m => m.UseSqlServer(e => e.MigrationsAssembly(typeof(GoodHabitsDbContext).Assembly.FullName)));

            var tenants = options.Tenants;
            foreach (var tenant in tenants)
            {
                string connectionString;
                if (string.IsNullOrEmpty(tenant.ConnectionString))
                {
                    connectionString = defaultConnectionString;
                }
                else
                {
                    connectionString = tenant.ConnectionString;
                }
                using var scope = services.BuildServiceProvider().CreateScope();
                var dbContext = scope.ServiceProvider.GetRequiredService<GoodHabitsDbContext>();
                dbContext.Database.SetConnectionString(connectionString);
                if (dbContext.Database.GetMigrations().Count() > 0)
                {
                    dbContext.Database.Migrate();
                }
            }
            return services;
        }
        public static T GetOptions<T>(this IServiceCollection services, string sectionName,IConfiguration config) where T : new()
        {
            var options = new T();
            config.GetSection(sectionName).Bind(options);
            return options;
        }
    }
}
