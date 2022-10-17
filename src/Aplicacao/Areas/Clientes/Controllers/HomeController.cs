using Aplicacao.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Aplicacao.Areas.Clientes.Controllers
{
    [Area("Clientes")]
    [Route("/client")]
    public class HomeController : Controller
    {
        private readonly ISessao _sessao;
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ObterClienteLogado()
        {
            var clienteLogado = _sessao.BuscarSessaoDoUsuario().Nome;
            return View(clienteLogado); 
           
        }
    }
}
