using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Category.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public virtual Categorys Category { get; set; }
    }
}