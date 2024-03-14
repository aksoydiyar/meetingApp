using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace MeetingApp.Controllers{
    public class HomeController:Controller
    {
    
        public IActionResult Index()
        {
            int saat=DateTime.Now.Hour;
            ViewBag.Selamlama=saat > 12 ? "Merhaba":"Günaydın";
            
            return View();

        }

    }
}