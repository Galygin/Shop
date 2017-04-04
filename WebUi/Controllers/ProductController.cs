using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Models;
using Repository.Repository;
using Services;

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
            DB.AddToCart(id);
            IEnumerable<Product> p= new List<Product>();
            return View("Ok",p);
        }

        [HttpPost]
        public ActionResult Remove(int id)
        {
            DB.RemoveProduct(id);
            return View("Ok");
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
            return View(product);
        }

        [HttpGet]
        public ActionResult ProductLis()
        {
            return View();
        }
    }
}