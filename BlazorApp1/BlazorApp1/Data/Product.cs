using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId  { get; set; }

        public override string ToString()
        {
            return $"Name:{Name} - Price : {Price} -Cat :{CategoryId}";
        }
    }
}
