using FluentValidator;
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
            User = user;
            Name = name;
            Email = email;
            BirthDate = null;

            new ValidationContract<Customer>(this)
                .IsRequired(x => x.Name.FirstName, "Nome é obrigatório")
                .HasMaxLenght(x => x.Name.FirstName, 50)
                .HasMinLenght(x => x.Name.FirstName, 3)
                .IsRequired(x => x.Name.LastName, "Sobre nome é obrigatório")
                .HasMaxLenght(x => x.Name.LastName, 50)
                .HasMinLenght(x => x.Name.LastName, 3);
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
