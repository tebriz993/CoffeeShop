using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Gallery:Base
    {
        

        [Required]
        public string Pictures { get; set; }



    }
}
