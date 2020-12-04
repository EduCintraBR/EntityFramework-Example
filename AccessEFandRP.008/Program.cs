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
                Name = "Eduardo Cintra",
                Birthday = DateTime.Parse("15/11/1996"),
                isActive = true,
                Salary = 1803
            };

            var prod1 = new Product
            {
                Id = Guid.NewGuid(),
                Name = "Notebook Dell Vostro 3583",
                Price = (decimal)4197.33
            };

            using (AppDataContext db = new AppDataContext())
            {
                //db.Customers.Add(cs);
                //db.Products.Add(prod1);
                //db.SaveChanges();

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
