using Microsoft.AspNetCore.Mvc;

namespace FlightBusBooking.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CountryController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
