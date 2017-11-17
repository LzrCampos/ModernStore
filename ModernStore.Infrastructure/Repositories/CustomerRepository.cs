using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MordenStore.Domain.Repositories;
using ModernStore.Infrastructure.Contexts;
using MordenStore.Domain.Entities;
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
            using (var conn = new SqlConnection(@"Server=.\SQLEXPRESS; Database=ModernStore; User Id=lazaro; password= 5289"))
            {
                var query = "SELECT * FROM [dbo].[GetCustomerInfoView] WHERE [Active] = 1 AND [UserName] = @username";
                conn.Open();
                return conn
                    .Query<GetCustomerCommandResult>(query,
                    new { username = username})
                    .FirstOrDefault();
            }

            //return _context
            //    .Customers
            //    .Include(x => x.User)
            //    .AsNoTracking()
            //    .Select(x => new GetCustomerCommandResult
            //    {
            //        Name = x.Name.ToString(),
            //        Document = x.Document.DocumentNumber,
            //        Active = x.User.Active.ToString(),
            //        Email = x.Email.EmailAdress,
            //        Password = x.User.Password,
            //        Username = x.User.UserName

            //    })
            //    .FirstOrDefault(x => x.Username == username);

        }
    }
}
