using Microsoft.AspNetCore.Mvc;
using MyFinalProject.Data;
using MyFinalProject.Models;
using MyFinalProject.Models.VMs;
using MyFinalProject.Repositiories;

namespace MyFinalProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IProductRep _rep;

        public ProductController(ApplicationDbContext context, IProductRep rep)
        {
            _context = context;
            _rep = rep;
        }

        public IActionResult _ListAll()
        {

            return View(_context.Prodtbl);
        }

        public IActionResult AddToCart(int prodId)

        {
              _context.tblOrders.Add(new Models.Orders { prodID = prodId });
            _context.SaveChanges();
            return RedirectToAction("_ListAll");
        }

        public IActionResult ShowCart()
        {
            var res = (from c in _context.tblOrders
                       join k in _context.Prodtbl
                       on c.prodID equals k.prodID
                       select new OrderVM
                       {
                           prodName = k.prodName,
                           prodPrice = k.prodPrice,


                       }
                       ).ToList();

            return PartialView("_Cart", res);
        }


        public IActionResult Show()
        {

            return View(_rep.ShowAll());
        }


        public IActionResult create()
        {
            // _context.Prodtbl.ToList();
            //ViewBag.cat = _context.Cattbl.ToList();
            return View();

        }

        [HttpPost]
        public IActionResult create(Product inf)
        {

            MemoryStream stream = new MemoryStream();

            //file data carry 
            inf.prodImage.CopyTo(stream);

            //ms to byte array

            inf.Img = stream.ToArray();

            //table name



            _rep.Create(inf);
            return RedirectToAction("Show");
        }

        public IActionResult Edit(int id)
        {
            return View(_rep.ShowProd(id));
        }

        [HttpPost]
        public IActionResult Edit(Product u)
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

            return View(_rep.ShowProdById(id));
        }


        public IActionResult Index()
        {
            return View();
        }
    }

}
