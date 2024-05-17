using Ecommerce.BusinessLogic.Dtos.CategoryDto;
using Ecommerce.BusinessLogic.Managers.Abstracts;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Repositories.Abstracts;
using Ecommerce.Domain.Repositories.implementations;
using Microsoft.AspNetCore.Http.HttpResults;

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

        public void Delete(int id )
        {
            var category= _categoryRepository.GetById( id );
            if( category != null )
            {
                _categoryRepository.Delete( category );
                _categoryRepository.SaveChanges();
            }
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

       
        public void Update(int id ,UpdateCategoryDto updatecategory)
        {
            var category = _categoryRepository.GetById(id);
            category.Name  = updatecategory.Name;
            category.Description = updatecategory.Description;
            _categoryRepository.Update(category);
            _categoryRepository.SaveChanges();
        }

        

    }
    }



   