using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainClasses
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }

        public Category()
        {
            CategoryId = Guid.NewGuid();
            Products = new List<Product>();
        }
    }
}
