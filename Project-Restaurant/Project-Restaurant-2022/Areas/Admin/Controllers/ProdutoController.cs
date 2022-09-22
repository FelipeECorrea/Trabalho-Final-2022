﻿using Microsoft.AspNetCore.Mvc;
using Repositorio.Enums;
using Servico.Servicos;
using Servico.ViewModels.Produto;
using Repositorio.Enums;
using Microsoft.AspNetCore.Hosting;

namespace Project_Restaurant_2022.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("/admin/produto")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProdutoController(IProdutoService produtoService, IWebHostEnvironment webHostEnvironment)
        {
            _produtoService = produtoService;
            _webHostEnvironment = webHostEnvironment;
        }


        // GET: ProdutoController
        public ActionResult Index()
        {
            var produtos = _produtoService.ObterTodos();

            return View(produtos);
        }

        [HttpGet("cadastrar")]
        public IActionResult Cadastrar()
        {
            var produto = ObterProduto();

            ViewBag.Produtos = ObterProduto();

            var produtoCadastrarViewModel = new ProdutoCadastrarViewModel();

            return View(produtoCadastrarViewModel);
        }

        [HttpPost("cadastrar")]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastrar([FromForm] ProdutoCadastrarViewModel produtoCadastrarViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Produtos = ObterProduto();

                return View(produtoCadastrarViewModel);
            }

            _produtoService.Cadastrar(produtoCadastrarViewModel, _webHostEnvironment.WebRootPath);

            return RedirectToAction("Index");
        }


        [HttpGet("galeria")]
        public IActionResult Galeria()
        {
            var produtos = _produtoService.ObterTodos();

            ViewBag.CaminhoServidor = _webHostEnvironment.WebRootPath;

            return View(produtos);
        }

        [HttpGet("editar")]
        public IActionResult Editar([FromQuery] int id)
        {
            var produtoEditarViewModel = _produtoService.ObterPorId(id);
            var produtos = ObterProduto();

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

            _produtoService.Editar(produtoEditarViewModel, _webHostEnvironment.WebRootPath);

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
