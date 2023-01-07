using System.ComponentModel.DataAnnotations;

namespace SoundBlog.Models
{
    public class Company
{

    [Key]
    public int CompanyID { get; set; }

    [Required]
    [StringLength(30)]
    public string CompanyName { get; set; }


    [Required]
    [StringLength(30)]
    public string CompanyManager { get; set; }

    [Required]
    [Range(10, 12, ErrorMessage = "Doğru bir yapıda telefon numarasını yazınız")]
    public int CompanyPhone { get; set; }

    [Required]
    [StringLength(50)]
    public string CompanyAddress { get; set; }

    

}
}

