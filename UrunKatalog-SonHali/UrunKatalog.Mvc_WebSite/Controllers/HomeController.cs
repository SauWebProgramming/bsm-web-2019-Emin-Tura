using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using UrunKatalog.Mvc_WebSite.Entity;

namespace UrunKatalog.Mvc_WebSite.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();




        // GET: Home
        public ActionResult Index()
        {

            var urunler = _context.Products
                    .Where(i => i.IsHome && i.IsApproved)
                     .Select(i => new Models.ProductModel()
                     {
                         Id = i.Id,
                         Name = i.Name,
                         Desription = i.Desription.Length > 50 ? i.Desription.Substring(0, 47) + "..." : i.Desription,
                         Price = i.Price,
                         Stock = i.Stock,
                         Image = i.Image,
                         CategoryId = i.CategoryId 
            
                         
                     }).ToList();

            return View(urunler);
        }
        public ActionResult Details(int? id)
        {
            return View(_context.Products.Where(i => i.Id == id).FirstOrDefaultAsync());
        }
        public ActionResult List(int? id) 
        {

            var urunler = _context.Products
                    .Where(i =>i.IsApproved)
                     .Select(i => new Models.ProductModel()
                     {
                         Id = i.Id,
                         Name = i.Name,
                         Desription = i.Desription.Length > 50 ? i.Desription.Substring(0, 47) + "..." : i.Desription,
                         Price = i.Price,
                         Stock = i.Stock,
                         Image = i.Image==null?"1.jpg":i.Image,
                         CategoryId = i.CategoryId


                     }).AsQueryable();

            if (id!= null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }


            return View(urunler.ToList());
        }

        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.ToList());
        }
    }
}