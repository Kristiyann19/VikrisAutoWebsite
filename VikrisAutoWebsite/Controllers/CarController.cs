using Microsoft.AspNetCore.Mvc;
using VikrisAutoWebsite.Core.Contracts;
using VikrisAutoWebsite.Core.Models;

namespace VikrisAutoWebsite.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService carService;

        public CarController(ICarService _carService)
        {
            carService = _carService;
        }

        public async Task<IActionResult> Cars()
        {
            var cars = await carService.GetAllCarsAsync();
            return View(cars);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            
            var model = new AddCarViewModel()
            {
                Engines = await carService.GetEnginesAsync(),
                Categories = await carService.GetCategoriesAsync(),
                Gearboxes = await carService.GetGearboxesAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCarViewModel car)
        {
            if (!ModelState.IsValid)
            {
                return View(car);
            }

            await carService.AddCarAsync(car);

            try
            {
                    return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");

                return View(car);
            }
        }

        public async Task<IActionResult> CarById(int carId)
        {
            if (!carService.Exists(carId))
            {
                return BadRequest();
            }

            var car = await carService.GetCarByIdAsync(carId);

            return View(car);
        }

       
        public async Task<IActionResult> RemoveCar (int carId)
        {
            //if (!carService.Exists(carId))
            //{
            //    return BadRequest();
            //}

            var cars = await carService.RemoveCarByIdAsync(carId);
            return View(cars);
        }

        public ActionResult EditTool()
        {
            return View();
        }
      
    }
}
