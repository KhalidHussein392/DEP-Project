

using Finally_DEPI.DAL.Models;

namespace Finally_DEPI.BL.Repository.Interface
{
    public interface IBrandRepository
    {
        Task<IEnumerable<Brand>> GetAllAsync();
        Task<Brand> GetByIdAsync(int? id);
        Task<IEnumerable<Brand>> GetByCategoryIdAsync(int? categoryId);
        Task AddAsync(Brand product);
        Task UpdateAsync(Brand product);
        Task DeleteAsync(Brand product);
    }
}
