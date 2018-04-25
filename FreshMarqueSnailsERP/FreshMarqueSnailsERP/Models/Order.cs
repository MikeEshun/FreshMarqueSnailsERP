using System;
using System.ComponentModel.DataAnnotations;

namespace FreshMarqueSnailsERP.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Customer")]
        public string CustomerName { get; set; } // refactor this to be a foreign key for customers table

        [Required]
        [Display(Name = "Contact")]
        public string Contact { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Location")]
        public string Location { get; set; }

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

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Delivery Date")]
        public DateTime DeliveryDate { get; set; }

        [Required]
        [Display(Name = "Delivery Status")]
        [StringLength(50, MinimumLength = 3)]
        public string DeliveryStatus { get; set; }

        public string Comment { get; set; }

        //[Display(Name = "Delivered By")]
        //public DispatchRider DispatchRider { get; set; }  // foreieng key for dispatch riders table. references the id column in dispatch rider table

        [Display(Name = "Payment Mode")]
        public int PaymentMethod { get; set; }  // foreign key for payment table

    }
}
