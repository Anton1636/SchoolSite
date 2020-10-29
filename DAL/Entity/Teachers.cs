using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    [Table("tblTeachers")]
    public class tblTeachers
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string ImageLink { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
