using Ecommerce.Domain.Data;
using Ecommerce.Domain.Repositories.Abstracts;

namespace Ecommerce.Domain.Repositories.implementations
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly EcommerceDbContext _context;
        public BaseRepository(EcommerceDbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

       public  void Delete (T entity)
        {
            _context.Set<T>().Remove(entity);
        }


        public  T GetById (int id)
        {
            return _context.Set<T>().Find(id);
       
         }


        public IQueryable<T> GetAll()
        {
            return _context.Set<T>().AsQueryable();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

       
    }
}
