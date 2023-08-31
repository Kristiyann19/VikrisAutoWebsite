using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VikrisAutoWebsite.Core.Contracts;
using VikrisAutoWebsite.Models;

namespace VikrisAutoWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICarService carService;

        public HomeController(ICarService _carService)
        {
            carService = _carService;
        }
       

        public async Task<IActionResult> Index()
        {
            var cars = await carService.GetAllCarsAsync();
            return View(cars);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}