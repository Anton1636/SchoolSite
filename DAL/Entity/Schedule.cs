using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    [Table("tblSchedule")]
    public class tblSchedule
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string TeacherName { get; set; }

        [Required]
        [MaxLength(50)]
        public string SubjectName { get; set; }

        [Required]
        public string StartTime { get; set; }
        
        [Required]
        public string EndTime { get; set; }

        [Required]
        public string DayWeek { get; set; }
    }
}
