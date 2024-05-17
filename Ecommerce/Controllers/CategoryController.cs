using Ecommerce.BusinessLogic.Dtos.CategoryDto;
using Ecommerce.BusinessLogic.Managers.Abstracts;
using Ecommerce.BusinessLogic.Managers.Implementations;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Ecommerce.Controllers
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpPost("Create")]
        public IActionResult CreateCategory(CreateCategoryDto categoryDto)
        {
            _categoryManager.Create(categoryDto);
            return Ok(categoryDto);
        }


        [HttpGet("get/{id}")]

        public ActionResult<ReadCategoryDto>ReadCategory(int id)
        {
            var category = _categoryManager.GetById(id);
            return Ok(category);
        }


        [HttpPut("update/{id}")]
       public IActionResult UpdateCategory(int id, UpdateCategoryDto updateCategoryDto)
        {
            var existingCategory = _categoryManager.GetById(id);
            if (existingCategory == null)
            {
            return NotFound();
            }

            _categoryManager.Update(id , updateCategoryDto);
            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteCategory(int id, DeleteCategoryDto deleteCategory) 
        {
           
            _categoryManager.Delete(id);
            return NoContent();
        
        }
       

           

    }
}
