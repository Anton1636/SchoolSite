using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public class CareerViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Career name:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string Name { get; set; }

        [Display(Name = "Career description:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string Description { get; set; }

        [Display(Name = "Career salary:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public int Salary { get; set; }
    }
}