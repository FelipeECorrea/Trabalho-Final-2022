using Microsoft.AspNetCore.Mvc;
using Servico.Servicos;

namespace Project_Restaurant_2022.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("/admin/ProdutoPedido")]
    public class ProdutoPedidoController : Controller
    {
        private readonly IProdutoPedidoService _produtoPedidoService;

        public ProdutoPedidoController(IProdutoPedidoService produtoPedidoService)
        {
            _produtoPedidoService = produtoPedidoService;
        }

        public ActionResult Index()
        {
            var produtosPedidos = _produtoPedidoService.ObterTodos();

            return View(produtosPedidos);
        }

        [HttpGet("abrir")]
        public ActionResult Abrir()
        {
            return View();
        }

        [HttpGet("ObterTodosProdutosPedidos")]
        public IActionResult ObterTodosProdutosPedidos()
        {
            var selectViewModel = _produtoPedidoService.ObterTodosProdutosPedidos();

            return Ok(selectViewModel);
        }

        [HttpGet("apagar")]
        public IActionResult Apagar([FromQuery] int id)
        {
            _produtoPedidoService.Apagar(id);

            return RedirectToAction("Index");
        }
    }
}
