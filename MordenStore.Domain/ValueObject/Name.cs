using FluentValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordenStore.Domain.ValueObject
{
    public class Name : Notifiable
    {
        protected Name()
        {

        }
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            new ValidationContract<Name>(this)
                .IsRequired(x => x.FirstName, "Nome é obrigatório")
                .HasMaxLenght(x => x.FirstName, 50, "Nome não pode conter mais que 50 caracteres")
                .HasMinLenght(x => x.FirstName, 3, "Nome não pode conter menos que 3 caracteres")
                .IsRequired(x => x.LastName, "Sobrenome é obrigatório")
                .HasMaxLenght(x => x.LastName, 50, "Sobrenome não pode conter mais que 50 caracteres")
                .HasMinLenght(x => x.LastName, 3, "Sobrenome não pode conter menos que 3 caracteres");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        
    }
}
