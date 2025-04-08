

using Finally_DEPI.DAL.Models;

namespace Finally_DEPI.BL.Repository.Interface
{
    public interface IShoppingCartRepository
    {
        Task<IEnumerable<ShoppingCart>> GetAllAsync();
        Task<ShoppingCart> GetByIdAsync(int? id);
        Task<IEnumerable<ShoppingCart>> GetByCategoryIdAsync(int? categoryId);
        Task AddAsync(ShoppingCart product);
        Task UpdateAsync(ShoppingCart product);
        Task DeleteAsync(ShoppingCart product);
    }
}
