using FlightBusBooking.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FlightBusBooking.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}