using Microsoft.AspNetCore.Mvc;
using ModernStore.Infrastructure.Transaction;
using MordenStore.Domain.Commands.Handlers;
using MordenStore.Domain.Commands.Inputs;

namespace ModernStore.Api.Controllers
{
    public class CustomerController : BaseController
    {
        private readonly CustomerCommandHandler _customerCommandHandler;

        public CustomerController(CustomerCommandHandler customerCommandHandler, IUow uow) : base(uow)
        {
            _customerCommandHandler = customerCommandHandler;
        }

        [HttpPost]
        [Route("v1/customers")]
        public IActionResult Post([FromBody]RegisterCustomerCommand command)
        {
            var result = _customerCommandHandler.Handle(command);
            return Response(result, _customerCommandHandler.Notifications);
        }
    }
}
