using Ecommerce.Domain.Entities;

namespace Ecommerce.Domain.Repositories.Abstracts
{
    public interface IBaseRepository<T> where T : class
    {
        void Create (T entity);

        void Update (T entity);
        void Delete (T entity); 
        public  T? GetById (int id);

        IQueryable<T> GetAll ();
         
        int SaveChanges();

    }
   


    

    

}
