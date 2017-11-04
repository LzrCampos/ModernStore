using ModernStore.Share.Commands;
using System;

namespace MordenStore.Domain.Commands.Result
{
    public class RegisterOrderCommandResult : ICommandResult
    {
        public RegisterOrderCommandResult()
        {
            
        }

        public RegisterOrderCommandResult(string number)
        {
            Number = number;
        }

        public string Number { get; set; }
    }
}
