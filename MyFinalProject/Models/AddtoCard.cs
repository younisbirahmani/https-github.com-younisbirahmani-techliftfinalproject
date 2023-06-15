using System.ComponentModel.DataAnnotations;

namespace MyFinalProject.Models
{
    public class AddtoCard
    {
        [Key]
        public int CartID { get; set; }

        public string? CatName { get; set; }
        public string? prodName { get; set; }
        public string? prodPrice { get; set; }



    }
}
