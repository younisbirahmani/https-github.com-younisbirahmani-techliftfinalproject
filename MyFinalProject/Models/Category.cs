using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinalProject.Models
{
    public class Category
    {
       [Key]
        public int CatID { get; set; }

        //? nullable
        [Required(ErrorMessage = "Category Name is required")]
        public string? CatName { get; set; }

        public string? CatDesc { get; set; }
        public int UserID { get; set; }
        [NotMapped]
        public IFormFile CatImage { get; set; }

        public byte[] Img { get; set; }


    }
}
