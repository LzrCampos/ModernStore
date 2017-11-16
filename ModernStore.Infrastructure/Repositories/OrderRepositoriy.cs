using MordenStore.Domain.Repositories;
using System;
using System.Linq;
using MordenStore.Domain.Entities;
using ModernStore.Infrastructure.Contexts;

namespace ModernStore.Infrastructure.Repositories
{
    public class OrderRepositoriy : IOrderRepository
    {
        private readonly ModernStoreDataContext _context;

        public OrderRepositoriy(ModernStoreDataContext context)
        {
            _context = context;
        }

        public void Save(Order order) => _context.Orders.Add(order);
    }
}
