using System;
using System.ComponentModel.DataAnnotations;

namespace FreshMarqueSnailsERP.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }  

        [Required]
        public string Name { get; set; }

        [Display(Name = "Phone No.")]
        public int Contact { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Supplier Reliability")]
        public string Reliability { get; set; }

        public SnailPurchase SnailSale { get; set; }

        [Display(Name = "Recent Supply")]
        public DateTime LastSupply { get; set; } // references purchase_date in purchases table
    }
}
