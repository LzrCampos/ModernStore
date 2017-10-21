using ModernStore.Share.Entities;
using MordenStore.Domain.ValueObject;
using System;
using System.Collections.Generic;

namespace MordenStore.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(User user, Name name, Email email, DateTime? birthDate)
        {
            this.User = user;
            this.Name = name;
            this.Email = email;
            this.BirthDate = null;

            // Validações
            //if (Name.FirstName.Length < 3)
            //    Notifications.Add("FirstName", "Nome invalido");
            //if (Name.LastName.Length < 3)
            //    Notifications.Add("LastName", "Nome invalido");
            //if (Email.email.Length < 3)
            //    Notifications.Add("Email", "Nome invalido");


        }

        public User User { get; private set; }
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public DateTime? BirthDate { get; set; }

        public override string ToString()
        {
            return $"{Name.FirstName} {Name.LastName}";
        }
    }

}
