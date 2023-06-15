using Microsoft.AspNetCore.Mvc;
using MyFinalProject.Data;
using MyFinalProject.Models;
using System.Diagnostics;

namespace MyFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
      
        public IActionResult Show()
        {
            return View();
        }

       


        public IActionResult main()
        {
         

            return View();
        }
        public IActionResult color()
        {
          

            return View();
        }

       

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}