using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.Data;
using MyFinalProject.Models;
using MyFinalProject.Repositiories;
using System.Data;

namespace MyFinalProject.Controllers
{
    [Authorize(Roles = "user")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserRep _rep;
        public UserController(ApplicationDbContext context,IUserRep rep)
        {
            _context = context;
            _rep = rep;
        }
       

      
        public IActionResult Show()
        {
            return View(_rep.ShowAll().ToList());
        }


        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult create(User id)
        {
            _rep.Create(id);
            return RedirectToAction("Show");
        }



        public IActionResult Edit(int id)
        {
            return View(_rep.ShowUser(id));
        }

        [HttpPost]
        public IActionResult Edit(User u)
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
            
            return View(_rep.ShowUserById(id));
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
