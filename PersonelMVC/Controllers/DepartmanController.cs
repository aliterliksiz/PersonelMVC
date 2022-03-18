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
        [Route("")]
        public ActionResult Merhaba()
        {
            var departman = new Departman() { Id = 5, Ad = "Bilgi işlem" };
            return View(departman);  // View --> Tarayıcıya HTML çıktı dönderen bir Action Result tipidir.
        }

        public ActionResult Test()
        {
            var departman = new Departman() { Id = 1, Ad = "Bilgi işlem" };
            return RedirectToAction("Index", "Personel", new { SortBy  = "Maas"});
        }

        public ActionResult Sil(int departmanId)
        {
            return Content("Gelen Id: " + departmanId);//Query String göndererek yazılabilir. Ya da route config'te değişiklik yapılabilir ama mantıksız bir çözüm.
        }

        public ActionResult Update(int departmanId, string ad)
        {
            return Content("DepartmanId: " + departmanId + "Ad: " + ad);
        }
    }
}