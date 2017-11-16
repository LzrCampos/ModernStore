using MordenStore.Domain.Commands.Result;
using MordenStore.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MordenStore.Domain.Repositories
{
    public interface IProductRepository
    {
        Product Get(Guid id);
        IEnumerable<GetProductListCommandResult> Get();

    }
}
