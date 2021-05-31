using System;
using System.Collections.Generic;
using System.Text;

namespace SatisSistemiDemo
{
    class Product : IProduct
    {
   
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public Categories Category { get; set; }
        public short Quantity { get; set; }
        public string ProductCode { get; set; }
    }
}
