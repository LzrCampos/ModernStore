using FluentValidator;
using ModernStore.Share.Entities;
using MordenStore.Domain.ValueObject;
using System;
using System.Collections.Generic;

namespace MordenStore.Domain.Entities
{
    public class Customer : Entity
    {
        protected Customer()
        {

        }
        public Customer(User user, Name name, Document document, Email email, DateTime? birthDate)
        {
            User = user;
            Name = name;
            Document = document;
            Email = email;
            BirthDate = null;

            AddNotifications(Name.Notifications);
            AddNotifications(Document.Notifications);
            AddNotifications(Email.Notifications);
        }

        public User User { get; private set; }
        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public DateTime? BirthDate { get; set; }

        public override string ToString()
        {
            return $"{Name.FirstName} {Name.LastName}";
        }
    }

}
