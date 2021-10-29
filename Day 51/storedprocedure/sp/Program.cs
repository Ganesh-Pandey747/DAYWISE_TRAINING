using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace sp
{
    public class user   // SRP Single Responsibility 
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Age { get; set; }
    }

    public class UserContext : DbContext
    {
        public UserContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)   // Open close principle
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=UserDB; integrated Security=true");
        }

        public DbSet<user> users { get; set; }// For manipulation weuse linq query or linq methods

    }
    public interface IUserReposiory
    {
        IEnumerable<user> fetchUsers();
        int  AddUser(user objuser);


    }

    class UserRepository : IUserReposiory
    {
         UserContext objcontext; // now we need migration technique to create database mechanically

        public UserRepository()
        {
            objcontext = new UserContext();
        }
        IEnumerable<user> IUserReposiory.fetchUsers()
        {
            return objcontext.users.FromSqlRaw("exec getusers").ToList();
            //return objcontext.users.FromSqlInterpolated($"SELECT * from users where id=1").ToList();
        }
        public int AddUser(user objuser)
        {
           var name = new SqlParameter("@un",objuser.Username);
           var ag = new SqlParameter("@ag", objuser.Age);
           objcontext.Database.ExecuteSqlRaw("exec addu '"+name.Value+"','"+ag.Value+"'");
           return 1;

        }
        class Program
        {
            static void Main(string[] args)
            {
                IUserReposiory urep = new UserRepository();
              
                user obj=new user();
                obj.Username="Deepak";
                obj.Age="32";
               urep.AddUser(obj);

                var userlist = urep.fetchUsers();
                foreach (user userObj in userlist)
                {
                    Console.WriteLine(userObj.Id + " " + userObj.Username + " " + userObj.Age);
                }
            }
        }
    }
}