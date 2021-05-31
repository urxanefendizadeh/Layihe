using System;
using System.Collections.Generic;
using System.Text;

namespace SatisSistemiDemo
{
    interface IItem
    {
        int Id { get; set; }
        IProduct Product { get; set; }
        decimal Count { get; set; }

    }
}
