using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinalProject.Models
{
    public class Product
    {
        [Key]
        public int prodID { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        public string? prodName { get; set; }

        public string? prodDesc { get; set; }

        public int CatID { get; set; }

        public string? prodStock { get; set; }
        public int UserID { get; set; }

        public int prodPrice { get; set; }

        [NotMapped]
        public IFormFile prodImage{ get; set; }

        public byte[]  Img { get; set; }

        //public string? CatName { get;  set; }
    }
}
