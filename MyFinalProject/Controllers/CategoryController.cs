using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.Data;
using MyFinalProject.Models;
using MyFinalProject.Repositiories;
using System.Data;

namespace MyFinalProject.Controllers
{
    [Authorize(Roles = "admin")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICategoryRep _rep;

        public CategoryController(ApplicationDbContext context, ICategoryRep rep)
        {
            _context = context;
            _rep = rep;
        }

        public IActionResult Show()
        {
            return View(_rep.ShowAll());
        }


        [AllowAnonymous] // do not use the security show the page , every one can show this View
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult create(Category inf)
        {
            MemoryStream stream = new MemoryStream();

            //file data carry 
            inf.CatImage.CopyTo(stream);

            //ms to byte array

            inf.Img = stream.ToArray();

            //table name



            _rep.Create(inf);
            return RedirectToAction("Show");



            
        }



        public IActionResult Edit(int id)
        {
            return View(_rep.ShowCat(id));
        }

        [HttpPost]
        public IActionResult Edit(Category u)
        {
            _rep.Update(u);
            return RedirectToAction("Show");
        }


        public IActionResult Delete(int ID)
        {
            _rep.Delete(ID);
            return RedirectToAction("Show");
        }


        public IActionResult Details(int id)
        {

            return View(_rep.ShowCatById(id));
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
