using System;
using System.ComponentModel.DataAnnotations;

namespace FreshMarqueSnailsERP.Models
{
    public class RetailSupply
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Supply Date")]
        public DateTime SupplyDate { get; set; }

        [Required]
        [Range(0, 0)]
        [Display(Name = "Large")]
        public int LargeSize { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int LargeSizeQuantity { get; set; }

        [Required]
        [Range(1, 1)]
        [Display(Name = "Medium")]
        public int MediumSize { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int MediumSizeQuantity { get; set; }

        [Required]
        [Range(2, 2)]
        [Display(Name = "Jumbo")]
        public int JumboSize { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int JumboSizeQuantity { get; set; }

        [Required]
        [Range(0, 2000)]
        [Display(Name = "Total Cost")]
        public decimal Cost { get; set; }

        public string Comment { get; set; }

        //public int RetailerId { get; set; }

        //[Display(Name = "Retailer")]
        //public Retailer Retailer { get; set; } // references id column in retialer table
    }
}
