using AccessEFandRP._008.Domain;
using System.Data.Entity.ModelConfiguration;

namespace AccessEFandRP._008.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customer");

            HasKey(x => x.Id);
            
            Property(x => x.isActive);
            Property(x => x.Birthday);
            Property(x => x.Name).HasMaxLength(50).IsRequired();
            Property(x => x.Salary);

        }
    }
}
