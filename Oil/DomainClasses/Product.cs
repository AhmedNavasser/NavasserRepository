using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainClasses
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(Order = 0)]
        public int ProductId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column(Order = 1)]
        public int ShipSerial { get; set; }
        public string ProductName { get; set; }
        public int CountOfBoxes { get; set; }
        public int ItemPerBox { get; set; }
        public string NetPrice { get; set; }
        public string Intrest { get; set; }
        public string FinalPrice { get; set; }

        [ForeignKey("CategoryId")]
        public Category ProductCategory { get; set; }
        public Guid CategoryId { get; set; }
    
    }
}
