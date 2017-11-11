using MordenStore.Domain.Repositories;
using System;
using System.Linq;
using MordenStore.Domain.Entities;
using System.Collections.Generic;
using ModernStore.Infrastructure.Contexts;
using MordenStore.Domain.Commands.Result;
using System.Data.SqlClient;
using Dapper;

namespace ModernStore.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ModernStoreDataContext _context;

        public ProductRepository(ModernStoreDataContext context)
        {
            _context = context;
        }

        public Product Get(Guid id)
        {
            return _context.Products.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<GetProductListCommandResult> Get()
        {
            using (var conn = new SqlConnection(@"Server=.\SQLEXPRESS; Database=ModernStore; User Id=lazaro; password= 5289"))
            {
                var query = "SELECT [Id], [Title], [Price], [Image] FROM [dbo].[Product]";
                conn.Open();
                return conn.Query<GetProductListCommandResult>(query);
            }
        }
    }
}
