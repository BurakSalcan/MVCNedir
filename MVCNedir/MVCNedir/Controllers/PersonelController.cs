using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCNedir.Models;


namespace MVCNedir.Controllers
{
    //Controller
    public class PersonelController : Controller
    {
        //Action

        //Action result olmadan view olsada çalışmaz
        public ActionResult Listele() //metoda sağ klik add view empty ve layoutsuz
        {
            return View();
        }
        public ActionResult VeriAktarim()
        {
            ViewBag.deneme = "Selamlar ben Samet yazılımcı olmaya çalışıyorum"; //en sık kullanılan
            ViewData["deneme2"] = "Merhaba ben viewdata";
            TempData["data"] = "tempdataaaaaaaa";
            return RedirectToAction("Listele", "Personel");
        }
        public ActionResult ModelIleVeriAktarimi()
        {
            Personel p = new Personel();
            p.ID = 1;
            p.Isim = "Murtaza";
            p.Soyisim = "Şuayipoğlu";
            return View(p);
        }
        [HttpGet]
        public ActionResult VeriAlalim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult VeriAlalim(string isim, string soyisim)
        {
            Personel p = new Personel();
            p.Isim = isim;
            p.Soyisim = soyisim;

            return View();
        }
        [HttpGet]
        public ActionResult ModelIleVeriAlalim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ModelIleVeriAlalim(Personel p)
        {

            return View();
        }
    }
}