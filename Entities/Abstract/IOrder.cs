using System;
using System.Collections.Generic;
using System.Text;

namespace SatisSistemiDemo
{
    interface IOrder
    {
        int Id { get; set; }
        decimal TotalPrice { get; set; }
        IItem Item { get; set; }
        DateTime Tarix { get; set; }
    }
}
