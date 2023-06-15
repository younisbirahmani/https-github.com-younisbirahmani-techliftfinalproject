using System.ComponentModel.DataAnnotations;

namespace MyFinalProject.Models
{
    public class Orders
    {

        [Key]
        public int OrderId { get; set; }

        public decimal OrdersTotal { get; set; }
        // public int ServiceId { get; set; }

        public int prodID { get; set; }



    }
}
