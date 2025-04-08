

using Finally_DEPI.DAL.Models;

namespace Finally_DEPI.DAL.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int? id);
        Task<IEnumerable<Product>> GetByCategoryIdAsync(int? categoryId);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(Product product);
    }
}
