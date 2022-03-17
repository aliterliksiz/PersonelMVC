using PersonelMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelMVC.Controllers
{
    public class DepartmanController : Controller
    {
        public ActionResult Merhaba()
        {
            var departman = new Departman() { Id = 5, Ad = "Bilgi işlem" };
            return View(departman);  // View --> Tarayıcıya HTML çıktı dönderen bir Action Result tipidir.
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}