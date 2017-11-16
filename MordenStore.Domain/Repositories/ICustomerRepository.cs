using MordenStore.Domain.Commands.Result;
using MordenStore.Domain.Entities;
using System;

namespace MordenStore.Domain.Repositories
{
    public interface ICustomerRepository
    {
        Customer Get(Guid id);

        GetCustomerCommandResult Get(string username);

        bool DocumentExist(string document);

        void Save(Customer customer);
    }
}
