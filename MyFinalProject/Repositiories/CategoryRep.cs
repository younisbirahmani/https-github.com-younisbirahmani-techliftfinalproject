using Microsoft.AspNetCore.Mvc;
using MyFinalProject.Data;
using MyFinalProject.Models;

namespace MyFinalProject.Repositiories
{
    public class CategoryRep : ICategoryRep
    {
        private readonly ApplicationDbContext _context;

        public CategoryRep(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Create()
        {
            return _context.SaveChanges();
        }

        [HttpPost]
        public int Create(Category d)
        {
            _context.Cattbl.Add(d);
            return _context.SaveChanges();
        }


        public int Delete(int Id)
        {
            _context.Cattbl.Remove(_context.Cattbl.Where(a => a.CatID == Id).SingleOrDefault());
            return _context.SaveChanges();
        }

        public int Detail(int id)
        {
            _context.Cattbl.Remove(_context.Cattbl.Where(a => a.CatID== id).SingleOrDefault());
            return _context.SaveChanges();
        }

        public IEnumerable<Category> ShowAll()
        {
            return _context.Cattbl.ToList();
        }

        public Category ShowCat(int id)
        {
            return _context.Cattbl.Where(a => a.CatID == id).SingleOrDefault();
        }

        public Category ShowCatById(int id)
        {
            return _context.Cattbl.Where(a => a.CatID == id).SingleOrDefault();
        }

        public int Update(Category c)
        {
            _context.Cattbl.Update(c);
            return _context.SaveChanges();
        }
    }
}
