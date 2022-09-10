using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositorio.Entidades;
using Servico.Servicos;
using Servico.ViewModels.Produto;
using Repositorio.Enums;

namespace Project_Restaurant_2022.Controllers
{
    [Route("produto")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        // GET: ProdutoController
        public ActionResult Index()
        {
            var produtos = _produtoService.ObterTodos();

            return View(produtos);
        }

        [HttpGet("cadastrar")]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost("cadastrar")]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(ProdutoCadastrarViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            _produtoService.Cadastrar(viewModel);

            return RedirectToAction("Index");
        }


        [HttpGet("editar")]
        public IActionResult Editar([FromQuery] int id)
        {
            var produto = _produtoService.ObterPorId(id);
            var produtos = ObterProduto();

            var produtoEditarViewModel = new ProdutoEditarViewModel
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor,
                Categoria = produto.Categoria,
                Descricao = produto.Descricao
            };
            ViewBag.Produtos = produtos;

            return View(produtoEditarViewModel);
        }

        [HttpPost("editar")]
        public IActionResult Editar([FromForm] ProdutoEditarViewModel produtoEditarViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Produtos = ObterProduto();

                return View(produtoEditarViewModel);
            }

            _produtoService.Editar(produtoEditarViewModel);

            return RedirectToAction("Index");
        }

        [HttpGet("obterTodosSelect2")]
        public IActionResult ObterTodosSelect2()
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

        [HttpGet("apagar")]
        // http://local:host:portaapagar?id=4
        public IActionResult Apagar([FromQuery] int id)
        {
            _produtoService.Apagar(id);

            return RedirectToAction("Index");
        }
    }
}
