using Microsoft.EntityFrameworkCore;
using ContactRepository.Models;
namespace ContactRepository.Context
{
    public class ContactsDbcontext:DbContext
    {
       public DbSet<Contact> contacts{get;set;}
       public ContactsDbcontext(DbContextOptions dbContextOptions):base(dbContextOptions)
       {
           
       } 
    }
}