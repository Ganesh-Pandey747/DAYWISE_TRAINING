
using System.Collections.Generic;
using myAutoMapperExample.myPOCO;
using Microsoft.EntityFrameworkCore;
using myAutoMapperExample.myContext;
using System.Linq;
using System;
namespace myAutoMapperExample.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        myDbContext context;
        DbSet<T> entities;
        public Repository(myDbContext context1)
        {
            context = context1;
            entities = context.Set<T>();  //here we are deciding what we are storing in T(User,Userprofile)
        }
        void IRepository<T>.Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentException();
            }
            context.Remove(entity);
            context.SaveChanges();
        }

        T IRepository<T>.Get(long id)
        {
            return entities.SingleOrDefault(t => t.Id == id);
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            var temp = entities.AsEnumerable();
            return temp;
        }

        void IRepository<T>.Insert(T entity)  //here we are distinguishing what we are storing in T(1.User,2.Userprofile)
        {
            context.Add(entity);
            context.SaveChanges();
        }
        void IRepository<T>.Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentException();
            }
            context.Remove(entity);
        }
        void IRepository<T>.SaveChanges()
        {
            context.SaveChanges();
        }

        void IRepository<T>.Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentException();
            }
            context.Update(entity);
            context.SaveChanges();
        }
    }
}