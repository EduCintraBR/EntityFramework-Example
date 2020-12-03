using AccessEFandRP._008.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
