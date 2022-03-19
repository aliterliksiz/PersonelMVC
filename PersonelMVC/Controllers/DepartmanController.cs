using PersonelMVC.Models;
using PersonelMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelMVC.Controllers
{
    public class DepartmanController : Controller
    {
        public ActionResult Gelen(int id)
        {
            var departman = new Departman() { Id = id, Ad = "Bilgi işlem" };
            //ViewBag.Departman = departman;
            //ViewBag.Ali = "Terliksiz";
            var personeller = new List<Personel>()
            {
                new Personel(){Ad="Personel - 1"},
                new Personel(){Ad="Personel - 2"},
                new Personel(){Ad="Personel - 3"}
            };
            var model = new DepartmanDetayViewModel()
            {
                Departman = departman,
                Personeller = personeller
            };
            return View(model);
        }
        public ActionResult Merhaba()
        {
            return Content("Anasayfa");
        }
    }
}