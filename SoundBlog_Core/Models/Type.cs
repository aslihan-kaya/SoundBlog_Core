using System.ComponentModel.DataAnnotations;

namespace SoundBlog.Models
{
    public class Type
    {
        [Key]
        public int TypeID { get; set; }

        [Required]
        [StringLength(30)]
        public string TypeName { get; set; }
    }
}
