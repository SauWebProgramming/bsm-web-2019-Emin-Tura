﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UrunKatalog.Mvc_WebSite.Entity;
using UrunKatalog.Mvc_WebSite.Models;
using System.Data;
using System.Net;
using System.Web.Mvc;


namespace UrunKatalog.Mvc_WebSite.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklaması")]
        public string Desription { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }
        public int CategoryId { get; set; }
        public  Category Category { get; set; }
    }
}