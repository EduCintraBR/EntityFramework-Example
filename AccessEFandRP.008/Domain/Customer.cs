using System;

namespace AccessEFandRP._008.Domain
{
    //[Table("Customer")]
    public class Customer
    {
        //[Key()]
        public Guid Id { get; set; }

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
