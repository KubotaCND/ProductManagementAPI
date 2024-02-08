using ProductsManagement.Data;
using ProductsManagement.Models;
using ProductsManagement.Repository.Interface;

namespace ProductsManagement.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Product> ObtainAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product FindProductById(int id)
        {
            return _context.Products.Find(id);

        }

        public Product FindProductByName(string name)
        {
            return _context.Products.Find(name);

        }

        public Product FindProductByCategory(int idCategory)
        {
            return _context.Products.Find(idCategory);

        }


        public int AddNewProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product.Id;
        }
        public Product? UpdateProductDescription(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return product;
        }

        public void RemoveProduct(int idProduct)
        {
            var product = FindProductById(idProduct);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();

            }
        }
    } } 
