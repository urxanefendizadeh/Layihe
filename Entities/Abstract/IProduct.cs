using System;
using System.Collections.Generic;
using System.Text;

namespace SatisSistemiDemo
{
    interface IProduct
    {
         string ProductName { get; set; }
         decimal UnitPrice { get; set; }
         Categories Category { get; set; }
         short Quantity { get; set; }
         string ProductCode { get; set; }
    }
}
