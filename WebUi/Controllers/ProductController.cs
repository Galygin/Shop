using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Models;
using Services;
using Domain;

namespace WebUi.Controllers
{
    public class ProductController : Controller
    {
        DataBases DB = new DataBases();

        [HttpGet]
        public ActionResult Index()
        {
            return View(DB.ReturnProduct());
        }

        [HttpPost]
        public ActionResult AddToCart(int id)
        {
            DB.AddToCart(id,User.Identity.Name);
            return RedirectToAction("Index","Product");
        }

        [HttpPost]
        public ActionResult Remove(int id)
        {
            DB.RemoveProduct(id);
            return RedirectToAction("Index", "Product");
        }

        [HttpPost]
        public ActionResult DeleteFromCart(int id)
        {
            DB.RemovePurchase(id);
            return RedirectToAction("Cart", "Product");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            DB.AddProduct(product);
            return RedirectToAction("Index", "Product");
        }

        [HttpGet]
        public ActionResult Cart()
        {
            ViewBag.Products = DB.ReturnProduct();
            ViewBag.ID = User.Identity.Name;
            return View(DB.ReturnPurchases());
        }
    }
}