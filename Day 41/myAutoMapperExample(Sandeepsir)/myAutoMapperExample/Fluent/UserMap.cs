using Microsoft.EntityFrameworkCore.Metadata.Builders;
using myAutoMapperExample.myPOCO;
namespace myAutoMapperExample.Fluent
{
    public class UserMap
    {
         public UserMap(EntityTypeBuilder<User> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Email).IsRequired();
            entityTypeBuilder.Property(t => t.Password).IsRequired();
            entityTypeBuilder.HasOne(t => t.userProfile).WithOne(t => t.user).HasForeignKey<UserProfile>(t => t.Id);
        }
    }
}