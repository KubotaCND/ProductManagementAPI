using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsManagement.Models;
using ProductsManagement.Repository;
using ProductsManagement.Repository.Interface;
using ProductsManagement.Repository.Interface2;

namespace ProductsManagement.Controllers
{
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        [HttpGet("[action]")]
        public List<Category> ObtainAllCategories()
        {
            return _categoryRepository.ObtainAllCategories();
        }


        [HttpGet("[action]/{id}")]
        public Category FindCategoryById(int id)
        {
            return _categoryRepository.FindCategoryById(id);
        }


        [HttpGet("[action]/{name}")]
        public Category FindCategoryByName(string name)
        {
            return _categoryRepository.FindCategoryByName(name);
        }


        [HttpDelete("[action]/{categoryId}")]
        public void RemoveProductsByCategory(int categoryId)
        {
            _categoryRepository.RemoveProductsByCategory(categoryId);
        }


    }
}
