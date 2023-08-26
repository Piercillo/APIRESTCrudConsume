using System.ComponentModel.DataAnnotations;

namespace CRUDWithWebAPI.Models
{
    public class Product
    {

        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Qty { get; set; }


    }
}
