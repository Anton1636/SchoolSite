using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public class GallaryViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Gallary imageLink:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string ImageLink { get; set; }

        [Display(Name = "Gallary description:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string Description { get; set; }
    }
}