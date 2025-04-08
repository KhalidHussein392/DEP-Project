

using Finally_DEPI.DAL.Models;

namespace Finally_DEPI.BL.Repository.Interface
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Product> GetByIdAsync(int? id);
        Task AddAsync(Category product);
        Task UpdateAsync(Category product);
        Task DeleteAsync(int? id);
    }
}
