using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kitapcim.Models;

namespace Kitapcim.Controllers
{
    public class MusteriController : Controller
    {

        private Kitapcim.Models.Yonetici.YoneticiDBContext musteridb = new Kitapcim.Models.Yonetici.YoneticiDBContext();

        // GET: /Musteri/
        public ActionResult Index()
        {
            var tur = musteridb.kitap.ToList();
            return View(tur);
        }


        //public ActionResult Browse(string tur)
        //{
        //    // Retrieve Genre and its Associated Albums from database
        //    var TurModel = musteridb.kitap.Include("Kitaplar")
        //        .Single(g => g.tur == tur);

        //    return View(TurModel);
        //}

      public ActionResult Details(int id)
        {
            var kitap = musteridb.kitap.Find(id);

            return View(kitap);
        }

        //
        // GET: /Store/GenreMenu

        [ChildActionOnly]
        public ActionResult TurMenu()
        {
            var tur = musteridb.kitap.ToList();

            return PartialView(tur);
        }

    }
}
     




