using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsManagement.Models;
using ProductsManagement.Repository.Interface;

namespace ProductsManagement.Controllers
{

    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        [HttpGet("[action]")]
        public List<Product> ObtainAllProducts()
        {
            return _productRepository.ObtainAllProducts();
        }

        [HttpGet("[action]/{id}")]
        public Product FindProductById(int id)
        {
            return _productRepository.FindProductById(id);

        }


        [HttpGet("[action]/{name}")]
        public Product FindProductByName(string name)
        {
            return _productRepository.FindProductByName(name);

        }


        [HttpGet("[action]/{idCategory}")]
        public Product FindProductByCategory(int idCategory)
        {
            return _productRepository.FindProductByCategory(idCategory);

        }


        [HttpPost("[action]")]
        public int AddNewProduct([FromBody]Product product)
        {

            return _productRepository.AddNewProduct(product);
        }

        [HttpPut("[action]")]
        public Product? UpdateProductDescription([FromBody]Product product)
        {
            return _productRepository.UpdateProductDescription(product);
        }

        [HttpDelete("[action]/{idProduct}")]
        public void RemoveProduct(int idProduct)
        {
            _productRepository.RemoveProduct(idProduct);
        }
    }
}

