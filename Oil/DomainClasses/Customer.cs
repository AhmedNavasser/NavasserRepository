using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class Customer
    {


        public Customer()
        {
            ContactInfos = new List<ContactInfo>();
        }


        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }

        public ICollection<ContactInfo>  ContactInfos { get; set; }
    }
}
