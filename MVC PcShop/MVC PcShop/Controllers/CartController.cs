using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_PcShop.Models;

namespace MVC_PcShop.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buy(string id)
        {
            PcComponentModel pccomponentModel = new PcComponentModel();
            if(Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Pccomponent = pccomponentModel.find(id), Quantity = 1 });
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Pccomponent = pccomponentModel.find(id), Quantity = 1 });
                }
                Session["cart"] = cart;
            }
            return RedirectToAction("Index");            
        }

        public ActionResult Remove(string id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            int index = isExist(id);
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return RedirectToAction("Index");
        }

        private int isExist(string id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Pccomponent.ID.Equals(id))
                    return i;
            return -1;
        }
    }
}