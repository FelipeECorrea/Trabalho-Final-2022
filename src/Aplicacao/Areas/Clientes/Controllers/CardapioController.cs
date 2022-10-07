﻿using Microsoft.AspNetCore.Mvc;
using Aplicacao.Helpers;
using Repositorio.Enums;
using Servico.Servicos;
using Servico.ViewModels.PedidoDoCliente;

namespace Aplicacao.Areas.Clientes.Controllers
{
    [Area("Clientes")]
    [Route("/client/cardapio")]
    public class CardapioController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly ISessao _sessao;

        public CardapioController(IProdutoService produtoService, ISessao sessao)
        {
            _produtoService = produtoService;
            _sessao = sessao;
        }

        public ActionResult Index()
        {
            var produtos = _produtoService.ObterTodos();

            return View(produtos);
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
