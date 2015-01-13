using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string SaleSerial { get; set; }
        [Required]
        public ICollection<Product> Products { get; set; }

        public ICollection<Category> ProductCategories { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public string SalesDate { get; set; }
        public DateTime SalesTime { get; set; }

        public Int64 TotalPrice { get; set; }

        /// <summary>
        /// ایجاد کلکسیونی از محصولات و گروهها و هر محصول به یک گروه مرتبط است
        /// </summary>
        public Sale()
        {
            Products = new List<Product>();
            ProductCategories = new List<Category>();
            
        }
    }
}
