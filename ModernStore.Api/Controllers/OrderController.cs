using ModernStore.Infrastructure.Transaction;
using MordenStore.Domain.Commands.Handlers;
using Microsoft.AspNetCore.Mvc;
using MordenStore.Domain.Commands.Inputs;

namespace ModernStore.Api.Controllers
{
    public class OrderController : BaseController
    {
        private readonly OrderCommandHandler _orderCommandHandler;

        public OrderController(OrderCommandHandler orderCommandHandler, IUow uow) : base(uow)
        {
            _orderCommandHandler = orderCommandHandler;
        }

        [HttpPost]
        [Route("v1/orders")]
        public IActionResult Post([FromBody]RegisterOrderCommand command)
        {
            var result = _orderCommandHandler.Handle(command);
            return Response(result, _orderCommandHandler.Notifications);
        }
    }
}
