using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IMSApplication.Models
{
    public class Supplier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int SupplierID { get; set; }
        
        [Required]
        [DisplayName("Supplier Name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [DisplayName("Supplier Address")]
        [StringLength(250)]
        public string Address { get; set; }
   
        [Required]
        [DisplayName("Phone No.")]
        [StringLength(11)]
        public string Phone { get; set; }

        public List<Product> Products { get; set; }
    }
}
