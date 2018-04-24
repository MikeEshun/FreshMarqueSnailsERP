using System.ComponentModel.DataAnnotations;

namespace FreshMarqueSnailsERP.Models
{
    public class SnailSpecification
    {
        public int SnailSpecificationId { get; set; }

        [Required]
        public string Size { get; set; }

        [Display]
        public decimal Height { get; set; }

        [Required]
        public decimal Width { get; set; }

        [Required]
        public string Description { get; set; }

        public int SnailTypeId { get; set; }

        [Display(Name = "Snail Type")]
        public SnailType SnailType { get; set; } // references id column of snail type table
    }
}
