using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servico.Servicos;
using Servico.ViewModels.Produto;

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
    }
}
