using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Assignment.Context;

namespace Assignment.DynamicMigration
{
    public static class CustomMigration
    {
        public static void MigrationInitilization(this IApplicationBuilder iApp)
        {
            using(var scopeObj = iApp.ApplicationServices.CreateScope())
            {
                scopeObj.ServiceProvider.GetService<UserDbContext>().Database.Migrate();
            }
        }
    }
}