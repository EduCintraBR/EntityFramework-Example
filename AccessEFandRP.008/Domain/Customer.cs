using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessEFandRP._008.Domain
{
    //[Table("Customer")]
    public class Customer
    {
        //[Key()]
        public int Id { get; set; }

        //[Required]
        //[StringLength(50)]
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        //[Required]
        //[DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        public bool isActive { get; set; }
    }
}
