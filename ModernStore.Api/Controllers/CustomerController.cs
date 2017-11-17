using Microsoft.AspNetCore.Mvc;
using ModernStore.Infrastructure.Transaction;
using MordenStore.Domain.Commands.Handlers;
using MordenStore.Domain.Commands.Inputs;
namespace ModernStore.Api.Controllers
{
    public class CustomerController : ControllerBase
    {
        private readonly CustomerCommandHandler _customerCommandHandler;
        private readonly IUow _uow;

        public CustomerController(CustomerCommandHandler customerCommandHandler, IUow uow)
        {
            _customerCommandHandler = customerCommandHandler;
            _uow = uow;
        }

        [HttpPost]
        [Route("customers")]
        public IActionResult Post([FromBody]RegisterCustomerCommand command)
        {
            var result = _customerCommandHandler.Handle(command);

            if (_customerCommandHandler.IsValid())
            {
                return Ok(result);
            }

            return BadRequest(_customerCommandHandler.Notifications);
        }
    }
}
