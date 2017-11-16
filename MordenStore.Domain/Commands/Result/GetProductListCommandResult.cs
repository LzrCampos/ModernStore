using ModernStore.Share.Commands;
using System;

namespace MordenStore.Domain.Commands.Result
{
    public class GetProductListCommandResult : ICommandResult
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
    }
}
