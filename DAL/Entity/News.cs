using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entity
{
    [Table("tblNews")]
    public class tblNews
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string DatePost { get; set; }

        [Required]
        public string LinkImage { get; set; }

        [Required]
        public string Description { get; set; }
    }

}
