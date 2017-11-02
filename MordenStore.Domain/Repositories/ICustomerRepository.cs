using MordenStore.Domain.Entities;
using System;

namespace MordenStore.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Customer Get(Guid Id);

        Customer Get(string document);

        Customer GetByUserId(Guid Id);

        bool DocumentExist(string Document);

        void Save(Customer customer);
    }
}
