using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System .Linq;

namespace OneToManyAssignment
{
    //Models
    public class Employee
    {
        public int EmpId{get; set;}
        public string EmpName{get; set;}
        public double EmpSalary{get; set;}
        public virtual Department Departments{get; set;}
    }

    public class Department
    {
        public int DepId{get; set;}
        public string Depname{get; set;}
        public virtual ICollection<Employee> Employees{get; set;}
        
    }

    //DbContext
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> EmpDb{get; set;}
        public DbSet<Department> DepDb{get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;User ID=postgres;Password=Postgre@1996;Database=OtmDB;Pooling=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DepId);
                entity.Property(e => e.Depname).IsRequired();
            });
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId);
                entity.Property(e => e.EmpName).IsRequired();
                entity.HasOne(d => d.Departments).WithMany(p => p.Employees);
            });
        }
    }


    class Program
    {
        public static void Main()
        {
            //inserting records
            Department department = new Department();
            /* department.DepId = 2;
            department.Depname = "HR"; */

            EmployeeContext employeeContext = new EmployeeContext();
            /* employeeContext.Add(department);
            employeeContext.SaveChanges(); */

            /* employeeContext.EmpDb.Add(new Employee{
                EmpId = 201,
                EmpName = "Rashi",
                EmpSalary = 300000.00,
                Departments = department
            });
            employeeContext.EmpDb.Add(new Employee{
                EmpId = 202,
                EmpName = "Divya",
                EmpSalary = 450000.00,
                Departments = department
            });
            employeeContext.SaveChanges(); */

            //Get Values
            
            var temp=employeeContext.EmpDb.Include(d => d.Departments);
            foreach(var item in temp)
            {
                Console.WriteLine(item.EmpName +"\n"+ item.EmpId + "\n");
            }
        }
    }
}