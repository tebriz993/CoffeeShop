using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class ContactUs:Base
    {
       

        [Required]
        [MaxLength(50,ErrorMessage ="Name 50 simvoldan cox ola bilmez.")]
        public string Name { get; set; }

        [Required]
        [MaxLength(75, ErrorMessage = "Email 75 simvoldan cox ola bilmez.")]
        public string Email { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Number 30 simvoldan cox ola bilmez.")]
        public int Number { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Message 1000 simvoldan cox ola bilmez.")]
        public string Message { get; set; }
    }
}
