using Finally_DEPI.BL.Repository.Interface;
using Finally_DEPI.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finally_DEPI.BL.Repository.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FinallyDEPIContext _context;

        public UnitOfWork(FinallyDEPIContext context)
        {
            _context = context;
            
        }

        public ICategoryRepository Categories { get;private set; }
        public IProductRepository Products { get; private set; }

        public IShoppingCartRepository ShoppingCart { get; private set; }

        public IBrandRepository Brands { get; private set; }

        public Task<int> CompleteAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
