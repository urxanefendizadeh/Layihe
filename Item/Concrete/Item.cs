using System;
using System.Collections.Generic;
using System.Text;

namespace SatisSistemiDemo
{
    class Item : IItem
    {
        public int Id { get; set; }
        public IProduct Product { get; set; }
        public decimal Count { get; set; }
    }
}
