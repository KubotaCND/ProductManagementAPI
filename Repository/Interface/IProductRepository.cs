using ProductsManagement.Models;

namespace ProductsManagement.Repository.Interface
{
    public interface IProductRepository
    {
        List<Product> ObtainAllProducts();
        Product FindProductById(int id);
        Product FindProductByName(string name);
        int AddNewProduct(Product product);
        Product? UpdateProductDescription(Product product);
        void RemoveProduct(int idProduct);
        Product FindProductByCategory(int idCategory);
    }
}
