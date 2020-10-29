using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    [Table("tblSchoolParty")]
    public class tblSchoolParty
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string FullDate { get; set; }

        [Required]
        public string ImageLink { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
