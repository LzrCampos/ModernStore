using ModernStore.Share.Commands;
using System;


namespace MordenStore.Domain.Commands.Inputs
{
    public class RegisterOrderItemCommand : ICommand
    {
        public Guid Product { get; set; }
        public int Quantity { get; set; }
    }
}
