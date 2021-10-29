using Microsoft.EntityFrameworkCore.Metadata.Builders;  // for supporting FluentApi
namespace usermanagementService.Models
{
    public class UserMap
    {
           public UserMap(EntityTypeBuilder<User> users)
           {
             users.HasKey(t=>t.Id);
             users.Property(t=>t.UserName).HasMaxLength(50);
             users.Property(t=>t.UserName).IsRequired();
             users.Property(t=>t.Age).HasMaxLength(2);
             users.Property(t=>t.Age).IsRequired();
           } 
        
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                            