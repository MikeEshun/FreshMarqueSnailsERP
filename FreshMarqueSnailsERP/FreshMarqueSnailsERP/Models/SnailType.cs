using System.ComponentModel.DataAnnotations;

namespace FreshMarqueSnailsERP.Models
{
    public class SnailType
    {
        public int SnailTypeId { get; set; }

        [Required]
        [Display(Name = "Snail Type")]
        public string Type { get; set; } // must be reference by snail specification table

        public SnailSpecification SnailSpecification { get; set; }
    }
}
