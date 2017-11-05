using MordenStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernStore.Infrastructure.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customer");
            HasKey(x => x.Id);
            Property(x => x.BirthDate);
            Property(x => x.Document.DocumentNumber);
            Property(x => x.Email.EmailAdress);
            Property(x => x.Name.FirstName);
            Property(x => x.Name.LastName);
            Property(x => x.User.UserName);
            Property(x => x.User.Password);
            Property(x => x.User.Active);

        }
    }
}
