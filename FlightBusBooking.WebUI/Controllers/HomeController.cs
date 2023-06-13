using FlightBusBooking.Business.Abstract;
using FlightBusBooking.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FlightBusBooking.WebUI.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ICountryService _countryService;

        public HomeController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public IActionResult Index()
        {
            return View(); 
        }

        public IActionResult Privacy()
        {
            return View(_countryService.GetCountries());
        }

    }
}