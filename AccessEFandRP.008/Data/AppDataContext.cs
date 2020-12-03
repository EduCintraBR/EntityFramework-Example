using AccessEFandRP._008.Domain;
using AccessEFandRP._008.Mapping;
using System.Data.Entity;

namespace AccessEFandRP._008.Data
{
    class AppDataContext : DbContext
    {
        public AppDataContext()
            :base("AppCnnStr")
        { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new ProductMap());
        }
    }
}
