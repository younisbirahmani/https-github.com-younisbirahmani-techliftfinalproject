using Microsoft.AspNetCore.Mvc;
using MyFinalProject.Data;
using MyFinalProject.Models;
using MyFinalProject.Models.VMs;

namespace MyFinalProject.Repositiories
{
    public class ProductRep : IProductRep
    {
        private readonly ApplicationDbContext _context;

        public ProductRep(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Create()
        {

           return _context.SaveChanges();
        
        }

        [HttpPost]
        public int Create(Product d)
        {
            _context.Prodtbl.Add(d);
            return _context.SaveChanges();

        }


        public int Delete(int Id)
        {
            _context.Prodtbl.Remove(_context.Prodtbl.Where(a => a.prodID == Id).SingleOrDefault());
            return _context.SaveChanges();
        }

        public int Detail(int id)
        {
            _context.Prodtbl.Remove(_context.Prodtbl.Where(a => a.prodID == id).SingleOrDefault());
            return _context.SaveChanges();
        }

        public IEnumerable<Product> ShowAll()
        {

           return (_context.Prodtbl.ToList());
            


        }
        
     

        public Product ShowProd(int id)
        {
            return _context.Prodtbl.Where(a => a.prodID == id).SingleOrDefault();
        }

       

        public Product ShowProdById(int id)
        {
            return _context.Prodtbl.Where(a => a.prodID == id).SingleOrDefault();
        }

        public int Update(Product u)
        {
            _context.Prodtbl.Update(u);
            return _context.SaveChanges();
        }

        
    }
}
