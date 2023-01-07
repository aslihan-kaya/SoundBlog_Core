using System;
using System.ComponentModel.DataAnnotations;

namespace SoundBlog.Models
{
    public class Artist
    {

        [Key]
        public int ArtistID { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtistName { get; set; }

        [Required]
        public DateTime ArtistBirth { get; set; }


        [Required]
        public int CompanyID { get; set; }

    }
}
