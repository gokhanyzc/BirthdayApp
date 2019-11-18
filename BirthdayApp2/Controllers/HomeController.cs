using BirthdayApp2.Models; //gerekli kütüphane.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace BirthdayApp2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DavetiyeFormu()
        {

            return View();

        }

        [HttpPost]

        public ActionResult DavetiyeFormu(DavetiyeModel model)
        {
            if (ModelState.IsValid)
            {
                VeriTabani.Add(model);
                return View("Thanks", model);

            }

            else
            {
                return View(model);
            }

        }

        public ActionResult Katilanlar()
        {
            Thread.Sleep(2000);
            //KATILANLARI LİSTELEDİ.
            return PartialView(VeriTabani.Liste.Where(i=>i.KatilmaDurumu == true));

        }

        public ActionResult KatilanAra(string q)
        {
            Thread.Sleep(2000);
            return PartialView(VeriTabani.Liste.Where(i => i.Ad.Contains(q))); //ad içerisinde arama yapar.
        }

    }
}