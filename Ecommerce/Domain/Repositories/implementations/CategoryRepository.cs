using Ecommerce.Domain.Data;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Repositories.Abstracts;

namespace Ecommerce.Domain.Repositories.implementations
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(EcommerceDbContext context) : base(context)
        {

        }
    }
}
