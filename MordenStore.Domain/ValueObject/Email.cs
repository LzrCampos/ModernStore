using FluentValidator;
using System;

namespace MordenStore.Domain.ValueObject
{
    public class Email : Notifiable
    {
        public Email(string email)
        {
            EmailAdress = email;

            new ValidationContract<Email>(this)
                .IsEmail(x => x.EmailAdress, "Email invalido");
        }

        public string EmailAdress { get; private set; }
    }
}
