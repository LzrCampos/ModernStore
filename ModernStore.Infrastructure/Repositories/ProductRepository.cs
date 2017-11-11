using MordenStore.Domain.Repositories;
using System;
using System.Linq;
using MordenStore.Domain.Entities;
using System.Collections.Generic;
using ModernStore.Infrastructure.Contexts;

namespace ModernStore.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ModernStoreDataContext _context;

        public Product Get(Guid id)
        {
            return _context.Products.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> Get(List<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }
}
