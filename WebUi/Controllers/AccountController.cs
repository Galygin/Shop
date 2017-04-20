using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domain.Models;
using Repository.Context;
using Services;
using System.Web.Security;

namespace WebUi.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                Account ac = null;
                using (ProductContext db = new ProductContext())
                {
                    //ac = db.Accounts.FirstOrDefault(u => u.Mail == model.Mail && u.Password == model.Password);
                }

                if (ac != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Mail, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "нет пользоватеей с такой почтой или паролем");
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {
            Account ac = null;
            using (ProductContext db = new ProductContext())
            {
                //ac = db.Accounts.FirstOrDefault(u => u.Mail == model.Mail);
            }

            if (ac == null)
                if (model.Password == model.ConfirmPassword)
                {
                    using (ProductContext db = new ProductContext())
                    {
                        Account User = new Account()
                        {
                            Mail = model.Mail,
                            Password = model.Password,
                            FirstName = model.FirstName,
                            LastName = model.LastName
                        };
                        /*db.Accounts.Add(User);
                        db.SaveChanges();
                        ac = db.Accounts.Where(u => u.Mail == model.Mail && u.Password == model.Password).FirstOrDefault();*/
                    }

                    if (ac != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Mail, true);
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с такими данными уже зарегистрирован");
                }
            return View();
        }

        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}