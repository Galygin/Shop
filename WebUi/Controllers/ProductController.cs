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
        public ActionResult Index(int id)
        {
            DB.AddToCart(id);
            IEnumerable<Product> p= new List<Product>();
            return View("Ok",p);
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