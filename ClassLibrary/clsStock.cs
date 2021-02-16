using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public string ProductDescription { get; set; }
    }
}