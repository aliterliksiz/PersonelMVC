using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelMVC.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        public ActionResult Index()
        {
            return Content("Personel Anasayfa");
        }

        [Route("personel/liste/{siralama}/{sayfa}")]
        public ActionResult PersonelListesi(string siralama, int sayfa)
        {
            return Content(siralama + "-" + sayfa);
        }
    }
}