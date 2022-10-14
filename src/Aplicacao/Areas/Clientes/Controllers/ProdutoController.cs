using Microsoft.AspNetCore.Mvc;
using Repositorio.Enums;
using Servico.Servicos;
using Servico.ViewModels.Produto;

namespace Aplicacao.Areas.Clientes.Controllers
{
    [Area("Clientes")]
    [Route("/client/produto")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }


        [HttpGet("obterPorId")]
        public IActionResult ObterPorId([FromQuery] int id)
        {
            var viewModel = _produtoService.ObterPorIdParaIndex(id);

            return Ok(viewModel);
        }
    }
}
