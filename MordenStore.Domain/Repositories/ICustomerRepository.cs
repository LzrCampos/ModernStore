using MordenStore.Domain.Entities;
using System;

namespace MordenStore.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Customer Get(Guid Id);
        Customer GetByUserId(Guid Id);
    }
}
