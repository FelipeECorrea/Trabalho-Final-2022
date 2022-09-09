using Microsoft.AspNetCore.Mvc;
using Servico.Servicos;
using Servico.ViewModels.Pedido;

namespace Project_Restaurant_2022.Controllers
{
    [Route("pedido")]
    public class PedidoController : Controller
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        public IActionResult Index()
        {
            var pedidos = _pedidoService.ObterTodos();

            return View(pedidos);
        }

        [Route("Cadastrar")]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [Route("cadastrar")]
        public ActionResult Cadastrar(PedidoCadastrarViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            _pedidoService.Cadastrar(viewModel);

            return RedirectToAction("Index");
        }
    }
}
