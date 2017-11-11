using MordenStore.Domain.Repositories;
using System;
using MordenStore.Domain.Entities;
using ModernStore.Infrastructure.Contexts;
using System.Data.Entity;
using System.Linq;
using MordenStore.Domain.Commands.Result;

namespace ModernStore.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ModernStoreDataContext _context;

        public CustomerRepository(ModernStoreDataContext context)
        {
            _context = context;
        }

        public Customer Get(Guid id) => _context.Customers.Include(x => x.User).FirstOrDefault(x => x.Id == id);

        public void Save(Customer customer) => _context.Customers.Add(customer);

        public bool DocumentExist(string document) => _context.Customers.Any(x => x.Document.DocumentNumber == document);

        public GetCustomerCommandResult Get(string username)
        {
            return _context
                .Customers
                .Include(x => x.User)
                .AsNoTracking()
                .Select(x => new GetCustomerCommandResult
                {
                    Name = x.Name.ToString(),
                    Document = x.Document.DocumentNumber,
                    Active = x.User.Active.ToString(),
                    Email = x.Email.EmailAdress,
                    Password = x.User.Password,
                    Username = x.User.UserName

                })
                .FirstOrDefault(x => x.Username == username);
        }
    }
}
