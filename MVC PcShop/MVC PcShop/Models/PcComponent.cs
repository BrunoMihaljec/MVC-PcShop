using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_PcShop.Models
{
    public class PcComponent
    {
        private string id;
        private string type;
        private string name;
        private string manufacturer;
        private double price;



        public PcComponent(string id, string type, string name, string manufacturer, double price)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }


        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}