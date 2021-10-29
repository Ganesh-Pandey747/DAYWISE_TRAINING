using UserManagement.Domain;
using System.Collections.Generic;
namespace UserManagement.Repository
{
   
   public interface IRepository<T> where T: BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
