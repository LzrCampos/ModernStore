using ModernStore.Share.Commands;
using System;

namespace MordenStore.Domain.CommandResults
{
    public class RegisterCustomerCommandResult : ICommandResult
    {
        public RegisterCustomerCommandResult()
        {
            
        }

        public RegisterCustomerCommandResult(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
        
        public Guid Id{ get; set; }
        public string Name { get; set; }

    }
}
