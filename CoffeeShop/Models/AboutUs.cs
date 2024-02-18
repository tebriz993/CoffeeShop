using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeShop.Models
{
    public class AboutUs:Base
    {
       

        [Required]
        [MaxLength(200, ErrorMessage = "Simvol sayi 200-den cox ola bilmez.")]
        [MinLength(3)]
        //[Column("BASLIQ")]
        public string Title { get; set; }

        [Required]
        [MaxLength(400,ErrorMessage ="Simvol sayi 400-den cox ola bilmez.")]
        [MinLength(3)]
        public string UpTitle { get; set; }
    }
}
