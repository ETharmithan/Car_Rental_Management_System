using Microsoft.AspNetCore.Mvc;

namespace Car_Rental_Management_System.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult View()
        {
            return View();
        }
    }
}
