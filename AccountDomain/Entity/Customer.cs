
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccountDomain.Entity
{
    public class Customer
    {
        public long Id { get; set; }
        [Key]
        public long CustomersId {
            get
                { return Id; }
            set
                { Id = value; }
        }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public List<Order> Orders {get; set; }
    }
}
