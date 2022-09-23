using Microsoft.AspNetCore.Mvc;

namespace Aplicacao.Areas.Admin.Controllers
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
