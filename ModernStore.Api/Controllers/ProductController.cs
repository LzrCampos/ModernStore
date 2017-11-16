using Microsoft.AspNetCore.Mvc;
using MordenStore.Domain.Repositories;
using System;

namespace ModernStore.Api.Controllerss
{
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("products")]
        public IActionResult Get()
        {
            return Ok(_repository.Get());
        }
    }
}
