using MordenStore.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MordenStore.Domain.Repositories
{
    public interface IProductRepository
    {
        Product Get(Guid id);
        IEnumerable<Product> Get(List<Guid> ids);
    }
}
