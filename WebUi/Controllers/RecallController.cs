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
    public class RecallController : Controller
    {
        DataBases DB = new DataBases();

        [HttpGet]
        public ActionResult Index()
        {
            return View(DB.ReturnRecall());
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
            return View();
        }

        [HttpPost]
        public ActionResult Remove(Recall rec)
        {
            DB.RemoveRecall(rec);
            return View();
        }
    }
}