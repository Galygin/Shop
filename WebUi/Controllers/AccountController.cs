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
    public class AccountController : Controller
    {
        DataBases DB = new DataBases();
        [HttpGet]
        public ActionResult Registry()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registry(Account ac)
        {
            ViewBag.Result = DB.Registry(ac);
            return View("Ok");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account ac)
        {
            ViewBag.Return = DB.Login(ac);
            return View(ac);
        }
        /*[HttpPost]
        public ActionResult Registry(Account ac)
        {
            if (DB.Registry(ac) == true)
                ViewBag.Result = "Регистрация прошла успешно";
            else
                ViewBag.Result = "Вы ввели некорректные данные, пожалуйста, повторите попытку и будьте внимательнее. Скорее всего аккаунт с такой почтой уже зарегистрирован, или вы ввели разные пароли";
            return View("Ok");
        }*/
    }
}