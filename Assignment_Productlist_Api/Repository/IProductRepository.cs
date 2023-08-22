using Assignment_Productlist_Api.Models;

namespace Assignment_Productlist_Api.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProductById(int id); // Change the parameter type to 'int'
        Task CreateProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(int id); // Change the parameter type to 'int'
    }
}
