using System;

namespace MordenStore.Domain.ValueObject
{
    public class Email
    {
        public Email(string email)
        {
            EmailAdress = email;
        }

        public string EmailAdress { get; private set; }
    }
}
