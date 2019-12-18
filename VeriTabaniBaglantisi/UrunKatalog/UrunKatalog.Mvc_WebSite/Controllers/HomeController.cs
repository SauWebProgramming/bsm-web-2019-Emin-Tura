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

   

            return View(_context.Products.Where(i=>i.IsHome && i.IsApproved).ToList());
        }
        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id == id).FirstOrDefault());
        }
        public ActionResult List()
        {
            return View(_context.Products.Where(i=> i.IsApproved).ToList());
        }
    }
}