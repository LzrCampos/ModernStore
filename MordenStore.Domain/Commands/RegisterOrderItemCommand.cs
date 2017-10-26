using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordenStore.Domain.Commands
{
    public class RegisterOrderItemCommand
    {
        public Guid Product { get; set; }
        public int Quantity { get; set; } 
    }
}
