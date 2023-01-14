using Microsoft.AspNetCore.Mvc;
using BitirmeProjesi.Models;
namespace BitirmeProjesi.Controllers
{
    public class AboutController : Controller
    {
        private readonly TravelContext _travelContext;
        public AboutController(TravelContext travelContext)
        {
            _travelContext= travelContext;
        }
        public IActionResult Index()
        {
            var degerler = _travelContext.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}
