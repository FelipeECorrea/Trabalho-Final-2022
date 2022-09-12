using Microsoft.AspNetCore.Mvc;
using Repositorio.Enums;
using Servico.Servicos;
using Servico.ViewModels.Pedido;
using Servico.ViewModels.Produto;

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

        public ActionResult Index()
        {
            var pedidos = _pedidoService.ObterTodos();

            return View(pedidos);
        }

        [HttpGet("abrir")]
        public ActionResult Abrir()
        {
            return View();
        }

        [HttpPost("abrir")]
        [ValidateAntiForgeryToken]
        public ActionResult Abrir([FromForm]PedidoCadastrarViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            _pedidoService.Cadastrar(viewModel);

            return RedirectToAction("Index");
        }

        // aqui

        [HttpGet("ObterTodosPedidos")]
        public IActionResult ObterTodosPedidos()
        {
            var selectViewModel = _pedidoService.ObterTodosPedidos();

            return Ok(selectViewModel);
        }

        [HttpGet("apagar")]
        // http://local:host:portaapagar?id=4
        public IActionResult Apagar([FromQuery] int id)
        {
            _pedidoService.Apagar(id);

            return RedirectToAction("Index");
        }
    }
}
