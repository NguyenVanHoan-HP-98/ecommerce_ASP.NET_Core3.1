using System;
using System.Collections.Generic;
using System.Text;

namespace ecommere.Data.entitis
{
    public class Product
    {
        public int ID { get; set; }
        public decimal Price { get; set; }
        public Decimal OriginalPrice { get; set; }
        public int Stok { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public string SeoAlisas { get; set; }
    }
}
