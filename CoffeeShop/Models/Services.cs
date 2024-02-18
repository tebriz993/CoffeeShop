using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Services:Base
    {
         

        [Required]
        public string Icon { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage ="Simvol sayi 50-den cox ola bilmez.")]
        public string Title { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "Simvol sayi 250-den cox ola bilmez.")]
        public string UpTitle { get; set; }
    }
}
