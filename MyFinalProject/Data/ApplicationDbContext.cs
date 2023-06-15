using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using MyFinalProject.Areas.Identity.Data;
using MyFinalProject.Models;

namespace MyFinalProject.Data
{
    public class ApplicationDbContext: IdentityDbContext<ProjectUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Cattbl { get; set; }

        public DbSet<Product> Prodtbl { get; set; }
        //public DbSet<Services> tblservice { get; set; }
        public DbSet<Orders> tblOrders { get; set; }

        public DbSet<User> Usertbl { get; set; }

        public DbSet<AddtoCard> Carttbl { get; set; }

    }
}
