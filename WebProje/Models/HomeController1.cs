using Microsoft.AspNetCore.Mvc;

namespace WebProje.Models
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
