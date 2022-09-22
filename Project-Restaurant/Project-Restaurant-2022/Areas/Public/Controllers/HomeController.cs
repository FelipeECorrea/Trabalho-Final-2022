using Microsoft.AspNetCore.Mvc;

namespace Project_Restaurant_2022.Areas.Public.Controllers
{
    [Area("Public")]
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
