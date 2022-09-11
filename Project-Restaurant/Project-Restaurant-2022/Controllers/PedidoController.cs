﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("cadastrar")]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost("cadastrar")]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(PedidoCadastrarViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            _pedidoService.Cadastrar(viewModel);

            return RedirectToAction("Index");
        }

        // aqui

        [HttpGet("obterTodosSelect2")]
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
