using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EfcorePractice
{
    public class  Product
    {
        [Key]
        public int Id{get;set;}
        public string Name{get;set;}
    }
    public class ProductContext:DbContext
    {
        private const string cs="Host=localhost;Port=5432;User ID=postgres;Password=1234;Database=practicedbb;Pooling=true";
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            dbContextOptions.UseNpgsql(cs);
        }
        public DbSet<Product> products{get;set;}// Table name will be  products
    }
    public class ProductOperation
    {
        ProductContext productContext=new ProductContext();
        public void FetchProduct(string str)
        {

          
           var prod = productContext.products.Where(s => s.Name == "Ganesh").FirstOrDefault();
           System.Console.WriteLine(prod.Id);


            //  var product = (from s in productContext.products
            //     where s.Name == str
            //     select s).FirstOrDefault<Product>();
            //     System.Console.WriteLine(product.Id);


            //  var temp=productContext.products.Find(101);
            //   if (temp != null)
            //     {
            //         Console.WriteLine(temp.Name);
            //     }          
        }

        public void InsertProduct()
        {
            var  std = new Product()
            {
                Id = 5,
                Name = "Gates"
            };
                productContext.products.Add(std);
                productContext.SaveChanges();      
        }


        // public void Update()
        // {
        //     var std = productContext.products.First<Product>(); 
        //     std.Name = "Steve";
        //     productContext.SaveChanges();
        // }

        // public void DeleteProduct()
        // {
        //      var std = productContext.products.First<Product>();
        //      productContext.products.Remove(std);
        //      productContext.SaveChanges();
        // }

        // public void Delete(int ID)
        // {
        //     var std=productContext.products.Find(ID);
        //     if(std!=null)
        //     {
        //         productContext.products.Remove(std);
        //         productContext.SaveChanges();
        //     }
        // }
    

    class Program
    {
        public static void Main()
        {
            ProductOperation productOperation=new ProductOperation();
            //productOperation.FetchProduct("Ganesh"); 
             productOperation.InsertProduct(); 
            // productOperation.Update(); 
            // productOperation.Delete(105);      
        }
    }
}
}
