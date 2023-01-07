using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace SoundBlog.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }

        [Required]
        [StringLength(30)]
        public string AlbumName { get; set; }

        [Required]
        public DateTime AlbumYear { get; set; }

        [Required]
        public int AlbunDuration { get; set; }

        [Required]
        public decimal AlbumPrice { get; set; }

        [Required]
        public int TypeID { get; set; }

        [Required]
        public int ArtistID { get; set; }
    }
}
