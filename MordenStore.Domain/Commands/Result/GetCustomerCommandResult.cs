namespace MordenStore.Domain.Commands.Result
{
    public class GetCustomerCommandResult
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Active { get; set; }
    }
}
