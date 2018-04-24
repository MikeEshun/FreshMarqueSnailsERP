using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FreshMarqueSnailsERP.Models
{
    public class DispatchRider
    {
        public int DispatchRiderId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Contact { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        [Display(Name = "Manager")]
        public string Supervisor { get; set; }

        [Display(Name = "Recent Delivery")]
        public int OrderId { get; set; }  // references the delivery date in orders table

        public List<Order> Orders { get; set; }
    }
}
