using ModernStore.Share.Commands;

namespace MordenStore.Domain.Commands.Result
{
    public class GetProductListCommandResult : ICommandResult
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
    }
}
