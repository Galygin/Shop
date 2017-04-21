using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain;
using Services;

namespace WebUi.Controllers
{
    public class RecallController : Controller
    {
        DataBases DB = new DataBases();

        [HttpGet]
        public ActionResult Index()
        {
            return View(DB.ReturnRecalls());
        }

        [HttpPost]
        public ActionResult Remove(int id)
        {
            DB.RemoveRecall(id);
            return RedirectToAction("Index", "Recall");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Recall rec)
        {
            DB.AddRecall(rec);
            return RedirectToAction("Index","Recall");
        }

    }
}