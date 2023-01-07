using System.ComponentModel.DataAnnotations;

namespace SoundBlog.Models
{
    public class Song
    {
        [Key]
        public int SongID { get; set; }

        [Required]
        [StringLength(30)]
        public string SingName { get; set; }

        [Required]
        [StringLength(30)]
        public string Lyricist { get; set; }

        [Required]
        public int SongDuration { get; set; }

        [Required]
        public int AlbumID { get; set; }

      
    }
}
