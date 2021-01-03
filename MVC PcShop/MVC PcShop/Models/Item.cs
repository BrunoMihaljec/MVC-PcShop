using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_PcShop.Models
{
    public class Item
    {
        private PcComponent pccomponent;
        private int quantity;

        public PcComponent Pccomponent
        {
            get { return pccomponent; }
            set { pccomponent = value; }
        }


        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
    }
}