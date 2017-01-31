using System;
using System.ComponentModel.DataAnnotations;

namespace AccountDomain.Entity
{
    public class Order
    {
        public long Id { get; set; }
        [Key]
        public long OrdersId
        {
            get
            { return Id; }
            set
            { Id = value; }
        }
        [Required]
        public Double Price { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public long CustomerId { get; set; }
    }
}
    