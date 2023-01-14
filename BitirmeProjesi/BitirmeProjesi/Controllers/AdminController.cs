using BitirmeProjesi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BitirmeProjesi.Controllers
{
    public class AdminController : Controller
    {
        private readonly TravelContext? _travelContext;
        
        public AdminController(TravelContext travelContext) {
            _travelContext = travelContext;
        }
        [Authorize]
        public IActionResult TurIndex()
        {
            var degerler = _travelContext.Turlars.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniTurEkle()
        {

            return View();
        }
        [HttpPost]
        public IActionResult YeniTurEkle(Turlar t)
        {
            _travelContext.Turlars.Add(t);
            _travelContext.SaveChanges();
            return RedirectToAction("TurIndex");
        }
        public IActionResult TurSil(int id)
        {
            var deger = _travelContext.Turlars.Find(id);
            _travelContext.Turlars.Remove(deger);
            _travelContext.SaveChanges();
            return RedirectToAction("TurIndex");
        }
        public IActionResult TurGetir(int id) {

            var deger = _travelContext.Turlars.Find(id);
            return View("TurGetir",deger);
        }
        public IActionResult TurGuncelle(Turlar t)
        {
            var tur = _travelContext.Turlars.Find(t.ID);
            tur.UlkeIsim = t.UlkeIsim;
            tur.SehirIsim = t.SehirIsim;
            tur.TurFiyat = t.TurFiyat;
            tur.UlkeResimUrl = t.UlkeResimUrl;
            tur.TurKacGun = t.TurKacGun;
            _travelContext.SaveChanges();
            return RedirectToAction("TurIndex");

        }
        [Authorize]
        public IActionResult GezilcekyerIndex()
        {
            var degerler = _travelContext.GezilcekYerlers.ToList();
            return View(degerler);
        }
        [HttpGet]
        public IActionResult GezilcekyerEkle()
        {

            return View();
        }
        [HttpPost]
        public IActionResult GezilcekyerEkle(GezilcekYerler g)
        {
            _travelContext.GezilcekYerlers.Add(g);
            _travelContext.SaveChanges();
            return RedirectToAction("GezilcekyerIndex");
        }
        public IActionResult GezilcekyerSil(int id)
        {
            var deger = _travelContext.GezilcekYerlers.Find(id);
            _travelContext.GezilcekYerlers.Remove(deger);
            _travelContext.SaveChanges();
            return RedirectToAction("GezilcekyerIndex");
        }
        public IActionResult GezilcekyerGetir(int id)
        {

            var deger = _travelContext.GezilcekYerlers.Find(id);
            return View("GezilcekyerGetir", deger);
        }
        public IActionResult GezilcekyerGuncelle(GezilcekYerler g)
        {
            var tur = _travelContext.GezilcekYerlers.Find(g.ID);
                tur.AnaBaslik=g.AnaBaslik;
                tur.Aciklama = g.Aciklama;
                tur.ResimUrl = g.ResimUrl;
            _travelContext.SaveChanges();
            return RedirectToAction("GezilcekyerIndex");

        }
 
    }
}
