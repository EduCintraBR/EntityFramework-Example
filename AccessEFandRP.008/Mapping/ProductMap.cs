using AccessEFandRP._008.Domain;
using System.Data.Entity.ModelConfiguration;

namespace AccessEFandRP._008.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product");

            HasKey(x => x.Id);

            Property(x => x.Name).HasMaxLength(80).IsRequired();
            Property(x => x.Price).HasPrecision(10, 2).IsRequired();
        }
    }
}
