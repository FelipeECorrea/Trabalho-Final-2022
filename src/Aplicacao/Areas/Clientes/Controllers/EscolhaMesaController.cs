using Aplicacao.Areas.Clientes.Views.Cardapio;
using Microsoft.AspNetCore.Mvc;
using Servico.Servicos;

namespace Aplicacao.Areas.Clientes.Controllers
{
    [Area("Clientes")]
    [Route("client/EscolhaMesa")]
    public class EscolhaMesaController : Controller
    {
        private readonly IMesaService _mesaService;

      
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ListasMesas()
        {
            var selectViewModel = _mesaService.ObterTodosSelect2();
            return View(selectViewModel);
        }

        [HttpGet]
        public IActionResult MesaEscolhida(int idMesa)
        {
            _mesaService.MesaEscolhida(idMesa);

            return RedirectToAction("client/pedido");
        }
    }


}
