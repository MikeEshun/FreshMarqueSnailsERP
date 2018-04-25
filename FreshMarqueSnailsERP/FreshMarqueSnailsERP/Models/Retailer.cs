using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FreshMarqueSnailsERP.Models
{
    public class Retailer
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Retailer")]
        public string Name { get; set; }

        [Display(Name = "Phone No.")]
        public int Contact { get; set; }

        [Required]
        [Display(Name = "Retail Location")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Retail Type")]
        public string Type { get; set; }  // online or brick n mortar

        //public List<RetailSupply> RetailSupplies { get; set; }
        // ok funny
    }
}
