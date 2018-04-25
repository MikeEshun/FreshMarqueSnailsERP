using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FreshMarqueSnailsERP.Models
{
    public class SnailPurchase
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Purchase Date")]
        public DateTime PurchaseDate { get; set; }

        [Required]
        [Display(Name = "Total Cost")]
        public decimal Cost { get; set; }

        public string Comment { get; set; }

        //[Display(Name = "Supplier")]
        //public int SupplierId { get; set; }

        //public Supplier Supplier { get; set; }
    }
}
