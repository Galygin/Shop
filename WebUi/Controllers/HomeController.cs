using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Models;
using Microsoft.SqlServer.Server;
using Repository.Context;
using System.Web.Security;

namespace WebUi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                ViewBag.Hi = User.Identity.Name;
            else
                ViewBag.Hi = "гость";
            return View();
        }
    }
}