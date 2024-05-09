using Ecommerce.BusinessLogic.Dtos.CategoryDto;


namespace Ecommerce.BusinessLogic.Managers.Abstracts
{
    public interface ICategoryManager
    {
        void Create(CreateCategoryDto category);
        ReadCategoryDto GetById(int id);
    }
}
