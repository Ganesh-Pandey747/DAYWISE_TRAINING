using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
namespace UserManagementSystem.Models
{
    // Now We are implementing FluentApi for defining the structure or schema for user
    public class UserMapper
    {
        public UserMapper(EntityTypeBuilder<User> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t=>t.UserId);
            entityTypeBuilder.Property(a=>a.UserName).IsRequired();//Isrequired==Not Null
            entityTypeBuilder.Property(a=>a.UserAge).IsRequired();
        }
    }
}