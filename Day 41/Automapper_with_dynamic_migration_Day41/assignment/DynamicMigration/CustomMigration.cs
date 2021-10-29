using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Assignment.Context;

namespace assignment.DynamicMigration
{
    public static class CustomMigration
    {
        public static void MigrationInitialisation(this IApplicationBuilder iapp)
        {
            using (var scope=iapp.ApplicationServices.CreateScope())
            {
                scope.ServiceProvider.GetService<UserDbContext>().Database.Migrate();
            }                                                   
        }
    }
}