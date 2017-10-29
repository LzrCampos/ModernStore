using System;
using ModernStore.Share.Commands;
using System.Collections.Generic;

namespace MordenStore.Domain.Commands
{
    public class RegisterOrderCommand : ICommand
    {
        public Guid Customer { get; set; }
        public decimal DeliveryFee { get; set; }
        public decimal Discount { get; set; }
        public IEnumerable<RegisterOrderItemCommand> Items { get; set; }

    }
}
