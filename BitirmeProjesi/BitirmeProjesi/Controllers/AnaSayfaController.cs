using BitirmeProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BitirmeProjesi.Controllers
{
    public class AnaSayfaController : Controller
    {
        private readonly TravelContext? _travelContext;

        public AnaSayfaController(TravelContext travelContext)
        {
            _travelContext = travelContext;
        }
        public IActionResult Index()
        {
            var degerler = _travelContext.Anasayfas.ToList();
            return View(degerler);
        }
    }
}
