using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using UrunKatalog.Mvc_WebSite.Entity;
namespace UrunKatalog.Mvc_WebSite.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desription { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
      
        public int CategoryId { get; set; } 
    }
}