using Microsoft.AspNetCore.Mvc;

namespace VikrisAutoWebsite.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
