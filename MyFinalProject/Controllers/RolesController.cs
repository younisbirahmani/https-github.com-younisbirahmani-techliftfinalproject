using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyFinalProject.Migrations;

namespace MyFinalProject.Controllers
{
    public class RolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

		public RolesController(RoleManager<IdentityRole> roleManager)
		{
			_roleManager = roleManager;
		}

		public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowRoles()
        {
            return View(_roleManager.Roles.ToList());
        }

		
		[HttpPost]
		public IActionResult CreateRole(string txtRole)
		{
			_roleManager.CreateAsync(new IdentityRole { Name = txtRole }).Wait();
			return RedirectToAction("ShowRoles");
		}

	}
}
