using System;

namespace eShopSolution.Data.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public int OriginalPrice { set; get; }
        public int Stock { set; get; }
        public DateTime DateCreated { set; get; }
        public string SeoAlias { set; get; }
    }
}
