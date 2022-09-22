using Microsoft.AspNetCore.Mvc;

namespace Aplicacao.Areas.Public.Controllers
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
