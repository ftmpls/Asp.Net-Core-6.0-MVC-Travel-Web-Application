
using Microsoft.AspNetCore.Mvc;
using BitirmeProjesi.Models;
namespace BitirmeProjesi.Controllers
{
    public class DefaultController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {

         
            return View();
        }
        public IActionResult İletisim()
        {
            return View();
        }
        public IActionResult Turlar()
        {
            return View();
        }
    }
}
