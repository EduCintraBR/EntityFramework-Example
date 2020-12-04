using AccessEFandRP._008.Data;
using AccessEFandRP._008.Domain;
using System;
using System.Linq;

namespace AccessEFandRP._008
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = new Customer
            {
                Id = Guid.NewGuid(),
                Name = "Eduardo Elias Barbosa Cintra",
                Birthday = DateTime.Parse("15/11/1996"),
                isActive = true,
                Salary = 2800
            };

            var prod1 = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Notebook Dell Vostro 3583",
                Price = (decimal)4197.33
            };

            using (AppDataContext db = new AppDataContext())
            {
                // Create
                //db.Customers.Add(cs);
                //db.Products.Add(prod1);
                //db.SaveChanges();

                // Update
                var customer1 = db.Customers
                                  .Where(x => x.Name == "Eduardo E B Cintra").FirstOrDefault();

                customer1.Name = "Edu Cintra";
                customer1.Salary = 2800;

                db.Entry<Customer>(customer1).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                // Delete
                //db.Customers.Remove(customer1);
                //db.SaveChanges();

                // Read
                var customer = db.Customers.ToList();
                var product = db.Products.ToList();

                foreach (var cst in customer)
                {
                    Console.WriteLine($"Id: {cst.Id} \n Name: {cst.Name} - Salary: {cst.Salary} \n");
                }
                foreach (var prd in product)
                {
                    Console.WriteLine($"Id: {prd.Id} \n Name: {prd.Name} - Price: {prd.Price} \n");
                }

            }
        }
    }
}
