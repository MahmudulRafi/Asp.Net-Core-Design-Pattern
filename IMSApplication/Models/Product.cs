using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IMSApplication.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int ProductID { get; set; }

        [Required]
        [DisplayName("Product Name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [DisplayName("Product Description")]
        [StringLength(250)]
        public string Description { get; set; }

        [Required]
        [DisplayName("Net Price")]
        public double Price { get; set; }

        [Required]
        [DisplayName("Product In Stock")]
        public int InStock { get; set; }

        [Required]
        [DisplayName("Product Supplier")]
        public int SupplierId { get; set; }

        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }
    }
}
