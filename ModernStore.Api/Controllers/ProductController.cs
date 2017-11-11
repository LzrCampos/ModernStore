using Microsoft.AspNetCore.Mvc;
using System;

namespace ModernStore.Api.Controllerss
{
    
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("products")]
        public string Get()
        {
            return "Listando todos os prdutos";
        }

        [HttpGet]
        [Route("products/{id}")]
        public string Product(Guid id)
        {
            return $"produto {id}";
        }

        [HttpPost]
        [Route("products")]
        public string Post()
        {
            return "Criando todos os prdutos";
        }
    }
}
