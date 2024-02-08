using ProductsManagement.Models;

namespace ProductsManagement.Repository.Interface2
{
    public interface ICategoryRepository
    {
        List<Category> ObtainAllCategories();
        Category FindCategoryById(int id);
        Category FindCategoryByName(string name);
        void RemoveProductsByCategory(int categoryId);


    }

}
