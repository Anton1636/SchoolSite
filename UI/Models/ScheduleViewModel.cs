using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public class ScheduleViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Teacher name:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string TeacherName { get; set; }

        [Display(Name = "Subject name:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        [MaxLength(50)]
        public string SubjectName { get; set; }

        [Display(Name = "Start Time:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string StartTime { get; set; }

        [Display(Name = "End Time:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string EndTime { get; set; }

        [Display(Name = "Day:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Must be not empty")]
        public string DayWeek { get; set; }
    }
}