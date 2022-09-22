using Microsoft.AspNetCore.Mvc;

namespace Project_Restaurant_2022.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("/admin/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
