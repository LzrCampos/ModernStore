using MordenStore.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MordenStore.Domain.Repositories
{
    public interface IProductRepository
    {
        Product Get(Guid Id);
        IEnumerable<Product> Get(List<Guid> Ids);
    }
}
