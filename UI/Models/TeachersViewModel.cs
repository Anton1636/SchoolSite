using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public class TeachersViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Teacher name:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string FullName { get; set; }

        [Display(Name = "Teacher image:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string ImageLink { get; set; }

        [Display(Name = "Teacher description:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string Description { get; set; }
    }
}