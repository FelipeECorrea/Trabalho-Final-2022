using Microsoft.AspNetCore.Mvc;
using Repositorio.Enums;
using Servico.Servicos;

namespace Aplicacao.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("/admin/ProdutoPedido")]
    public class ProdutoPedidoController : Controller
    {
        private readonly IProdutoPedidoService _produtoPedidoService;
        private readonly IProdutoService _produtoService;
        private readonly IPedidoService _pedidoService;

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

        //[HttpGet("obterPorId")]
        //public IActionResult ObterPorId([FromQuery] int id)
        //{
        //    var produtos = _produtoService.ObterPorId(id);
        //    if (produtos.Status != StatusProduto.Disponivel)
        //    {
        //        return Ok(produtos);
        //    }

        //    var pedidos = _pedidoService.ObterPorId(id);

        //    return View();
        //}
    }
}
