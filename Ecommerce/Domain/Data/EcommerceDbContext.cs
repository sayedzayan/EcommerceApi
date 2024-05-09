
using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Ecommerce.Domain.Data
{
    public class EcommerceDbContext :DbContext
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext>options)
            : base(options)
        {
            
        }

        public DbSet<Product> Products=>Set<Product>(); 
        public DbSet<Category>Categories =>Set<Category>();

        protected override void OnModelCreating (ModelBuilder modelbuilder)
        {
           modelbuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelbuilder);
        }


    }
}
