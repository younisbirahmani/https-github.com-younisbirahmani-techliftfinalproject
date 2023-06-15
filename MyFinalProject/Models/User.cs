using System.ComponentModel.DataAnnotations;

namespace MyFinalProject.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [StringLength(20, ErrorMessage = "Length can not more than 10")]
        public string UserName { get; set; }

        
        public string UserPassword { get; set; }

        [Required(ErrorMessage = "Email  is required")]
        public string UserEmail { get; set; }

        public int UserPhonenumber { get; set; }
       

    }
}
