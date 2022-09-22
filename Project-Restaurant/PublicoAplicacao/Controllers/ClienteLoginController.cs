﻿using Microsoft.AspNetCore.Mvc;
using Repositorio.Enums;
using Servico.Servicos;
using Servico.ViewModels.Cliente;
using Servico.ViewModels.LoginCliente;

namespace PublicoAplicacao.Controllers
{
    [Route("ClienteLogin")]
    public class ClienteLoginController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClienteLoginController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public ActionResult Index()
        {
            var viewModel = new LoginClienteViewModel();

            return View(viewModel);
        }

        [HttpGet("cadastrar")]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost("cadastrar")]
        [ValidateAntiForgeryToken]
        public ActionResult Cadastrar(ClienteCadastrarViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            _clienteService.Cadastrar(viewModel);

            return RedirectToAction("Index");
        }

        [HttpGet("editar")]
        public IActionResult Editar([FromQuery] int id)
        {
            var cliente = _clienteService.ObterPorId(id);
            var clientes = ObterCliente();

            var clienteEditarViewModel = new ClienteEditarViewModel
            {
                Nome = cliente.Nome,
                Telefone = cliente.Telefone,
                Cpf = cliente.Cpf,
                Email = cliente.Email,
            };
            ViewBag.Clientes = cliente;

            ViewBag.Clientes = cliente;

            return View(clienteEditarViewModel);
        }

        [HttpPost("editar")]
        public IActionResult Editar([FromForm] ClienteEditarViewModel clienteEditarViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Clientes = ObterCliente();
                return View(clienteEditarViewModel);
            }

            return View(clienteEditarViewModel);


            _clienteService.Editar(clienteEditarViewModel);

            return RedirectToAction("Index");

        }

        private List<string> ObterCliente()
        {
            return Enum
               .GetNames<ClienteEmMesa>()
               .OrderBy(x => x)
               .ToList();
        }

    }
}
        