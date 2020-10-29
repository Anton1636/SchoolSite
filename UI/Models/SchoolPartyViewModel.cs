using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public class SchoolPartyViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Party date:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string FullDate { get; set; }

        [Display(Name = "Party image:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string ImageLink { get; set; }

        [Display(Name = "Party dscription:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string Description { get; set; }
    }
}