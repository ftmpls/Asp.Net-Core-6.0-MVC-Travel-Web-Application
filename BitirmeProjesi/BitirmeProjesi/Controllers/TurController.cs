using Microsoft.AspNetCore.Mvc;
using BitirmeProjesi.Models;
using System.Security.Policy;

namespace BitirmeProjesi.Controllers
{
    public class TurController : Controller
    {
        private readonly TravelContext _travelContext;
        public TurController(TravelContext travelContext)
        {
            _travelContext = travelContext; 
        }
   
       
        public IActionResult Index()
        {
            var degerler=_travelContext.Turlars.ToList();
         
            return View(degerler);
        }
        TurVeYer tum = new TurVeYer();
        public IActionResult GezilcekYerler(int id)
        {
            tum.Deger1 = _travelContext.Turlars.Where(x => x.ID == id);
            tum.Deger2 = _travelContext.GezilcekYerlers.Where(x => x.TurID == id);
            return View(tum);
            
         
        }
    }
}
