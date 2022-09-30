using Microsoft.AspNetCore.Mvc;
using Aplicacao.Helpers;
using Repositorio.Enums;
using Servico.Servicos;
using Servico.ViewModels.PedidoDoCliente;
using Servico.ViewModels.Mesa;
using Aplicacao.Areas.Admin.Views.Mesa;

namespace Aplicacao.Areas.Clientes.Controllers
{
    [Area("Clientes")]
    [Route("cardapio")]
    public class PedidoController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly IMesaService _mesaService;
        private readonly ISessao _sessao;

        public PedidoController(IProdutoService produtoService, ISessao sessao)
        {
            _produtoService = produtoService;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("abrir")]
        public IActionResult Abrir()
        {
            var cardapio = new PedidoDoClienteCadastrarViewModel();

            return View(cardapio);
        }

        [HttpPost("abrir")]
        public IActionResult Abrir(PedidoDoClienteCadastrarViewModel viewModel)
        {
            var cardapio = new PedidoDoClienteCadastrarViewModel();

            var cliente = _sessao.BuscarSessaoDoUsuario();
            cardapio.ClienteId = cliente.Id;

            return View(cardapio);
        }

        [HttpGet("obterTodosProdutos")]
        public IActionResult ObterTodosProdutos()
        {
            var selectViewModel = _produtoService.ObterTodosSelect2();

            return Ok(selectViewModel);
        }

        private List<string> ObterProduto()
        {
            return Enum
                .GetNames<StatusProduto>()
                .OrderBy(x => x)
                .ToList();
        }
    }
}
