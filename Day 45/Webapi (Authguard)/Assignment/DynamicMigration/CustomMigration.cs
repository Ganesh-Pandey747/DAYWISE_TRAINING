using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Assignment.Context;

namespace Assignment.DynamicMigration
{
    public static class CustomMigration
    {
        //Extension Method for Migration
        public static void MigrationInitialization(this IApplicationBuilder applicationBuilder)
        {
            using(var scope=applicationBuilder.ApplicationServices.CreateScope())  //CreateScope will make a database once and then it washoff 
            {
                scope.ServiceProvider.GetService<UserDbContext>().Database.Migrate();
            }
        }
    }
}