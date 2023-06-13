using AutoMapper;
using FlightBusBooking.Entities.Concrete;
using FlightBusBooking.WebUI.Areas.Admin.Models.UserModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FlightBusBooking.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public UserController(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }
        // açıklamaaa
        public IActionResult Index()
        {
            var user = _userManager.Users.ToList();
            var userModel = _mapper.Map<List<UserModel>>(user);
            return View(userModel);
        }
    }
}
