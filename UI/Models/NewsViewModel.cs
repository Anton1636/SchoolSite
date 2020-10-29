using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public class NewsViewModel
    {
        public int Id { get; set; }
        
        [Display(Name = "News Title:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string DatePost { get; set; }
        
        [Display(Name = "Image:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string LinkImage { get; set; }

        [Display(Name = "Description:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string Description { get; set; }
    }
}