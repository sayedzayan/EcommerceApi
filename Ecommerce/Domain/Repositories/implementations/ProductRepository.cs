using Ecommerce.Domain.Data;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Repositories.Abstracts;

namespace Ecommerce.Domain.Repositories.implementations
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(EcommerceDbContext context) : base(context)
        {
        }
    }
}
