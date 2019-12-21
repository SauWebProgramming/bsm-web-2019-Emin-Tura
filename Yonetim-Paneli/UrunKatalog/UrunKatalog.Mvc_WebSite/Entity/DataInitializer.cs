using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UrunKatalog.Mvc_WebSite.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> kategoriler = new List<Category>
            {
                new Category(){ Name = "Kamera", Description = "Kamera Ürünleri"},
                new Category(){ Name = "Bilgisayar", Description = "Bilgisayar Ürünleri"},
                new Category(){ Name = "Elektronik", Description = "Elektronik Ürünleri"},
                new Category(){ Name = "Telefon", Description = "Telefon Ürünleri"},
                new Category(){ Name = "Beyaz Eşya", Description = "Beyaz Eşya Ürünleri"}

            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);

            }
            context.SaveChanges();

            List<Product> urunler = new List<Product>
            {
                new Product() {Name="Camera",Desription="CameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCamera", Price=1200, Stock=5, IsApproved=true,CategoryId=1, IsHome=true,Image="1.jpg"},
                new Product() {Name="Camera",Desription="CameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCamera", Price=1200, Stock=5, IsApproved=true,CategoryId=1, IsHome=true,Image="2.jpg"},
                new Product() {Name="Camera",Desription="CameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCameraCamera", Price=1200, Stock=5, IsApproved=true,CategoryId=1, IsHome=true,Image="3.jpg"},
                new Product() {Name="Camera",Desription="Camera", Price=1200, Stock=5, IsApproved=true,CategoryId=1, IsHome=true,Image="4.jpg"},
                new Product() {Name="Camera",Desription="Camera", Price=1200, Stock=5, IsApproved=true,CategoryId=1,Image="5.jpg"},

                new Product() {Name="Bilgisayar",Desription="Bilgisayar", Price=1200, Stock=5, IsApproved=true,CategoryId=4, IsHome=true,Image="1.jpg"},
                new Product() {Name="Bilgisayar",Desription="Bilgisayar", Price=1200, Stock=5, IsApproved=true,CategoryId=4, IsHome=true,Image="2.jpg"},
                new Product() {Name="Bilgisayar",Desription="Bilgisayar", Price=1200, Stock=5, IsApproved=true,CategoryId=4, IsHome=true,Image="3.jpg"},
                new Product() {Name="Bilgisayar",Desription="Bilgisayar", Price=1200, Stock=5, IsApproved=true,CategoryId=4,Image="4.jpg"},
                new Product() {Name="Bilgisayar",Desription="Bilgisayar", Price=1200, Stock=5, IsApproved=true,CategoryId=4,Image="5.jpg"},

                new Product() {Name="Elektronik",Desription="Elektronik", Price=1200, Stock=5, IsApproved=true,CategoryId=2, IsHome=true,Image="1.jpg"},
                new Product() {Name="Elektronik",Desription="Elektronik", Price=1200, Stock=5, IsApproved=true,CategoryId=2, IsHome=true,Image="2.jpg"},
                new Product() {Name="Elektronik",Desription="Elektronik", Price=1200, Stock=5, IsApproved=true,CategoryId=2,Image="3.jpg"},
                new Product() {Name="Elektronik",Desription="Elektronik", Price=1200, Stock=5, IsApproved=true,CategoryId=2,Image="4.jpg"},
                new Product() {Name="Elektronik",Desription="Elektronik", Price=1200, Stock=5, IsApproved=true,CategoryId=2, IsHome=true,Image="5.jpg"},

                new Product() {Name="Telefon",Desription="Telefon", Price=1200, Stock=5, IsApproved=true,CategoryId=3, IsHome=true,Image="1.jpg"},
                new Product() {Name="Telefon",Desription="Telefon", Price=1200, Stock=5, IsApproved=true,CategoryId=3, IsHome=true,Image="2.jpg"},
                new Product() {Name="Telefon",Desription="Telefon", Price=1200, Stock=5, IsApproved=true,CategoryId=3, IsHome=true,Image="3.jpg"},
                new Product() {Name="Telefon",Desription="Telefon", Price=1200, Stock=5, IsApproved=true,CategoryId=3,Image="4.jpg"},
                new Product() {Name="Telefon",Desription="Telefon", Price=1200, Stock=5, IsApproved=true,CategoryId=3,Image="5.jpg"},

              

            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();



            base.Seed(context);
        }
    }
}