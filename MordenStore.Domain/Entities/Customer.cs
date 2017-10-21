using MordenStore.Domain.ValueObject;
using System;

namespace MordenStore.Domain.Entities
{
    public class Customer
    {
        public Customer(User user, Name name, Email email, DateTime? birthDate)
        {
            this.User = user;
            this.Name = name;
            this.Email = email;
            this.BirthDate = null;
        }

        public User User { get; private set; }
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public DateTime? BirthDate { get; set; }
    }
}
