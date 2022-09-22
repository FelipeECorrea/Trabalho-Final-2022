using Microsoft.AspNetCore.Mvc;
using Repositorio.Enums;
using Servico.Servicos;

namespace PublicoAplicacao.Controllers
{
    [Route("EntrarCardapio")]
    public class CardapioController : Controller
    {
        private readonly IProdutoService _produtoService;
        public IActionResult Index()
        {
            return View();
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
