using Ecommerce.BusinessLogic.Dtos.CategoryDto;
using Ecommerce.BusinessLogic.Managers.Abstracts;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Repositories.Abstracts;
using Ecommerce.Domain.Repositories.implementations;

namespace Ecommerce.BusinessLogic.Managers.Implementations
{

    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Create(CreateCategoryDto categoryDto)
        {
            var CategoryToAdd = new Category()
            {
                Name = categoryDto.Name,
                Description = categoryDto.Description,
            };
            _categoryRepository.Create(CategoryToAdd);

            _categoryRepository.SaveChanges();

        }

        public ReadCategoryDto GetById(int id)
        {
            var category = _categoryRepository.GetById(id);
            if (category == null)
            
                throw new Exception("Not Found");

                var CategoryToReturn = new ReadCategoryDto()
                {
                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description,

                };

            return CategoryToReturn;
           // throw new NotImplementedException();

        }
    }
    }



   