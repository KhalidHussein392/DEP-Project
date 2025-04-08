using Finally_DEPI.BL.Repository.Interface;
using Finally_DEPI.DAL.Context;
using Finally_DEPI.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finally_DEPI.BL.Repository.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly FinallyDEPIContext context;

        public CategoryRepository(FinallyDEPIContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(Category category)
        {
            await context.Categories.AddAsync(category);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            
        }

        public async Task DeleteAsync(int? id)
        {
            var category = await context.Categories.FindAsync(id);
            if (category != null)
            {
                context.Categories.Remove(category);
                await context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await context.Categories.ToListAsync();
        }


        

        public async Task<Category> GetByIdAsync(int? id)
        {
            return await context.Categories.FirstOrDefaultAsync(p=>p.Id==id);

        }

        public async Task UpdateAsync(Category category)
        {
            context.Categories.Update(category);
            await context.SaveChangesAsync();
        }

        Task<Product> ICategoryRepository.GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
