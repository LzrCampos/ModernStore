using MordenStore.Domain.Entities;
using System;

namespace MordenStore.Domain.Repositories
{
    public interface IOrderRepository
    {
        void Save(Order order);
    }
}
