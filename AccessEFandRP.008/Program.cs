using AccessEFandRP._008.Data;
using System.Linq;

namespace AccessEFandRP._008
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AppDataContext db = new AppDataContext())
            {
                var context = db.Customers.ToList();
            }
        }
    }
}
