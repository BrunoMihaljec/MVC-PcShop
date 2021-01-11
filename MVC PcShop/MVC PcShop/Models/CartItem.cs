using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_PcShop.Models
{
    public class CartItem
    {
        public int Quantity { get; set; }

        public virtual PcComponent PcComponent { get; set; }
    }
}