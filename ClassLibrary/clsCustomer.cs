using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public DateTime CustomerRegisteredDate { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public double Point { get; set; }
        public int ProductId { get; set; }
    }
}