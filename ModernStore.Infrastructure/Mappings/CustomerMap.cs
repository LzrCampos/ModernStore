using MordenStore.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ModernStore.Infrastructure.Mappings
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customer");
            HasKey(x => x.Id);
            Property(x => x.BirthDate);
            Property(x => x.Document.DocumentNumber).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.Email.EmailAdress).IsRequired().HasMaxLength(160);
            Property(x => x.Name.FirstName).IsRequired().HasMaxLength(60);
            Property(x => x.Name.LastName).IsRequired().HasMaxLength(60);
            HasRequired(x => x.User);

        }
    }
}
