using System.ComponentModel.DataAnnotations;

namespace MVC_Project.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(50)]

        public string Name { get; set; }
        public List<Product> Products { get; set; }=new List<Product>();
    }
}
