using BitirmeProjesi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace BitirmeProjesi.Controllers
{
    public class GirisYapController : Controller
    {
        private readonly TravelContext? _travelContext;
        public GirisYapController(TravelContext travelContext)
        {
           _travelContext = travelContext;
        }

       public IActionResult Login()
        {
            return View();
       }
       [HttpPost]
        public async Task<IActionResult> Login(Admin admin)
      {
          var adminUser=_travelContext.Admins.FirstOrDefault(x=>x.Kullanici==admin.Kullanici && x.Sifre==admin.Sifre);
          if (adminUser !=null)
            {
             var claims = new List<Claim>{
            new Claim(ClaimTypes.Name,admin.Kullanici)
     };
       ClaimsIdentity useridentiy=new ClaimsIdentity(claims,"Login");
       ClaimsPrincipal principal = new ClaimsPrincipal(useridentiy);
       await HttpContext.SignInAsync(principal);
                return Redirect("/Admin/TurIndex");
            }
        else
           {
                Redirect("/GirisYap/Login");
            
               
            }
           return View();
          }
        public async Task<IActionResult> CikisYap()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }

   }
}

