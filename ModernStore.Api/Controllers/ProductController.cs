using Microsoft.AspNetCore.Mvc;
using ModernStore.Api.Controllers;
using MordenStore.Domain.Repositories;
using System;
using ModernStore.Infrastructure.Transaction;

namespace ModernStore.Api.Controllerss
{
    public class ProductController : BaseController
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository, IUow uow) : base(uow)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("v1/products")]
        public IActionResult Get()
        {
            return Ok(_repository.Get());
        }
    }
}
