using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace OneToMany
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpEmail { get; set; }
        
       
        public virtual Department Department { get; set; }
    }

    public class Department
    {
        public int DepID { get; set; }
        public string DepName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }

    public class DepartmentContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }

        public DbSet<Department> Department { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;User ID=postgres;Password=1234;Database=EmployeeDepartmentDB;Pooling=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Well Structuredness with reationship (Using FluentApi)
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DepID);
                entity.Property(e => e.DepName).IsRequired();
            });


            modelBuilder.Entity<Employee>(entity =>
           {
               entity.HasKey(e => e.EmpId);
               entity.Property(e => e.EmpEmail).IsRequired();
               entity.HasOne(d => d.Department)
               .WithMany(p => p.Employees);
           });


        }
    }


    public class Controller
    {
        public static void Main()
        {
            DepartmentContext obj1 = new DepartmentContext();
            Department obj = new Department();
            obj.DepID = 125;
            obj.DepName = "Computer Science"; 
            obj1.Add(obj);
            obj1.SaveChanges();

            obj1.Employee.Add(new Employee
            {
                EmpId = 101,
                EmpName = "Ganesh",
                EmpEmail = "Ganesh747.com", 
                Department = obj

            });

            obj1.Employee.Add(new Employee
            {
                EmpId = 102,
                EmpName = "Nikhil",
                EmpEmail = "Niks555.com", 
                Department = obj
            });
            obj1.SaveChanges();

            // var employees =obj1.Employee.Include(ctr=>ctr.Department);
            // foreach(var Employee in employees)
            // {
            //     System.Console.WriteLine(Employee.EmpId+" "+Employee.EmpEmail+" "+Employee.Department.DepID+" "+Employee.Department.DepName);

            // }

            var employees =obj1.Employee.Include(ctr=>ctr.Department.DepID);
            foreach(var Employee in employees)
            {
                System.Console.WriteLine(Employee.EmpId+" "+Employee.EmpEmail+" "+Employee.Department.DepID+" "+Employee.Department.DepName);

            }
        }
    }
}

