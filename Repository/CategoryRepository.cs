using Microsoft.EntityFrameworkCore;
using ProductsManagement.Data;
using ProductsManagement.Models;
using ProductsManagement.Repository.Interface;
using ProductsManagement.Repository.Interface2;

namespace ProductsManagement.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        private readonly IProductRepository _productRepository;

        public CategoryRepository(AppDbContext context, IProductRepository productRepository)
        {
            _context = context;
            _productRepository = productRepository;
        }


        public List<Category> ObtainAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category FindCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }

        public Category FindCategoryByName(string name)
        {
            return _context.Categories.Find(name);

        }

        public void RemoveProductsByCategory(int categoryId)
        {
            {
                var product = _productRepository.FindProductByCategory(categoryId);
                if (product != null)
                {
                    _context.Products.Remove(product);
                    _context.SaveChanges();
                }
            }

        }


    }
}
