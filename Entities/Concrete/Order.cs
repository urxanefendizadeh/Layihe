using System;
using System.Collections.Generic;
using System.Text;

namespace SatisSistemiDemo
{
    class Order : IOrder
    {
        public int Id { get ; set ; }
        public decimal TotalPrice { get; set; }
        public IItem Item { get; set; }
        public DateTime Tarix { get;set; }
    }
}
