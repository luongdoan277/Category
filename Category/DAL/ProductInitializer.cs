using Category.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Category.DAL
{
    public class ProductInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var products = new List<Product>
            {
                new Product{CategoryID=1, ProductName="Iphone X", Price= 99},
                new Product{CategoryID=1, ProductName="Iphone Xr",Price= 99},
                new Product{CategoryID=2, ProductName="Samsung s10",Price= 99},
                new Product{CategoryID=2, ProductName="Samsung not10",Price= 99},
                new Product{CategoryID=3, ProductName="Laptop gaming",Price= 99},
                new Product{CategoryID=3, ProductName="Laptop Dell",Price= 99},
            };
            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            var categories = new List<Categorys>
            {
                new Categorys{CategoryName="Apple",},
                new Categorys{CategoryName="Samsung",},
                new Categorys{CategoryName="Laptop",},
            };
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();
        }
    }
}